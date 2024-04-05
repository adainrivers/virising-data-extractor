using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;
using Newtonsoft.Json;
using VRising.Configuration;

namespace VRising.Localization
{
    public class GoogleTranslateClient
    {
        private readonly Language _language;
        private readonly Dictionary<string, string> _translationCache = new();
        private readonly string _translationCachePath;
        private readonly TranslationClient _translationClient;

        public GoogleTranslateClient(Language language)
        {
            _language = language;
            _translationCachePath = Path.Combine(AppConfig.DataFolder, "TranslationCache", $"{language.GoogleLanguageCode}.json");

            if (File.Exists(_translationCachePath))
            {
                _translationCache =
                    JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(_translationCachePath));
            }

            var credentials = GoogleCredential.FromFile(AppConfig.GoogleApiJsonFilePath);
            _translationClient = TranslationClient.Create(credentials);

        }

        public string Translate(string key)
        {
            if (_language.GoogleLanguageCode == LanguageCodes.English)
            {
                return key;
            }
            if (_translationClient == null)
            {
                return key;
            }

            if (_translationCache.TryGetValue(key, out var translatedText))
            {
                return translatedText;
            }

            var toBeTranslated = key;
            var replaceBack = false;
            if (toBeTranslated.Contains("V Rising"))
            {
                toBeTranslated = toBeTranslated.Replace("V Rising", "{999}");
                replaceBack = true;
            }


            var translation = _translationClient.TranslateText(toBeTranslated, _language.GoogleLanguageCode, LanguageCodes.English, TranslationModel.NeuralMachineTranslation);
            translatedText = translation.TranslatedText;
            if (replaceBack)
            {
                translatedText = translatedText.Replace("{999}", "V Rising");

            }
            _translationCache[key] = translatedText;
            Console.WriteLine($"Google Translate: '{key}' -> '{translatedText}'");
            SaveTranslations();
            return _translationCache[key];
        }

        private void SaveTranslations()
        {
            File.WriteAllText(_translationCachePath, JsonConvert.SerializeObject(_translationCache, Formatting.Indented));
        }
    }
}
