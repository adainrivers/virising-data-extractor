using System.Collections;
using Gaming.Tools.Shared.RouteLocalization;
using Google.Cloud.Translation.V2;

namespace VRising.Localization
{
    public class LanguageFactory : IReadOnlyDictionary<string, Language>
    {
        static LanguageFactory()
        {
            var languages = new List<Language>()
            {
                new Language(LanguageCodes.Arabic, "Arabic.json"),
                new Language(LanguageCodes.Portuguese, "Brazilian.json"),
                new Language(LanguageCodes.Danish, "Danish.json"),
                new Language(LanguageCodes.English, "English.json"),
                new Language(LanguageCodes.French, "French.json"),
                new Language(LanguageCodes.German, "German.json"),
                new Language(LanguageCodes.Hungarian, "Hungarian.json"),
                new Language(LanguageCodes.Italian, "Italian.json"),
                new Language(LanguageCodes.Japanese, "Japanese.json"),
                new Language(LanguageCodes.Korean, "Koreana.json"),
                new Language(LanguageCodes.Polish, "Polish.json"),
                new Language(LanguageCodes.Russian, "Russian.json"),
                new Language(LanguageCodes.ChineseTraditional, "TChinese.json"),
                new Language(LanguageCodes.ChineseSimplified, "SChinese.json"),
                new Language(LanguageCodes.Spanish, "Spanish.json"),
                new Language(LanguageCodes.Thai, "Thai.json"),
                new Language(LanguageCodes.Turkish, "Turkish.json"),
                new Language(LanguageCodes.Ukrainian, "Ukrainian.json"),
            };
            Languages = languages.ToDictionary(l => l.LanguageCode, StringComparer.OrdinalIgnoreCase);
        }
        public static readonly Dictionary<string, Language> Languages;

        private readonly CurrentLanguage _currentLanguage;

        public LanguageFactory(CurrentLanguage currentLanguage)
        {
            _currentLanguage = currentLanguage;
        }

        public Language Current => Languages.ContainsKey(_currentLanguage.Code) ? Languages[_currentLanguage.Code] : throw new InvalidOperationException($"Invalid language code: {_currentLanguage.Code}");

        public IEnumerator<KeyValuePair<string, Language>> GetEnumerator() => Languages.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public int Count => Languages.Count;
        public bool ContainsKey(string key) => Languages.ContainsKey(key);
        public bool TryGetValue(string key, out Language value) => Languages.TryGetValue(key, out value);
        public Language this[string key] => Languages[key];
        public IEnumerable<string> Keys => Languages.Keys;
        public IEnumerable<Language> Values => Languages.Values;
    }
}
