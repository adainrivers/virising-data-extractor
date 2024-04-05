using System.Globalization;
using Google.Cloud.Translation.V2;

namespace VRising.Localization;

public class Language
{
    private readonly GoogleTranslateClient _googleTranslateClient;
    private readonly Dictionary<Guid, string> _gameLocalizations;
    private readonly Dictionary<string, Guid> _reverseLookup = new Dictionary<string, Guid>();

    public Language(string googleLanguageCode, string gameLocalizationFileName)
    {
        LanguageCode = googleLanguageCode.ToLowerInvariant();
        GoogleLanguageCode = googleLanguageCode;
        GameLocalizationFileName = gameLocalizationFileName;
        Culture = new CultureInfo(googleLanguageCode);
        _googleTranslateClient = new GoogleTranslateClient(this);
        _gameLocalizations = GameLocalization.Load(gameLocalizationFileName);
        if (googleLanguageCode == LanguageCodes.English)
        {
            foreach (var gameLocalization in _gameLocalizations)
            {
                _reverseLookup[gameLocalization.Value] = gameLocalization.Key;
            }
        }

    }

    public CultureInfo Culture { get; }
    public string LanguageCode { get; }
    public string LocalizedName => Culture.TextInfo.ToTitleCase(Culture.NativeName);

    public string GoogleLanguageCode { get; }
    public string GameLocalizationFileName { get; }

    public string PathPrefix
    {
        get
        {
            if (LanguageCode == "en")
            {
                return string.Empty;
            }

            return "/" + LanguageCode;
        }
    }

    public string Translate(string original, Guid guid, Dictionary<string, string> parameters = null)
    {
        if (!_gameLocalizations.TryGetValue(guid, out var translation))
        {
            return BuildDescription(original, parameters);
        }

        return BuildDescription(translation, parameters);
    }

    public string Translate(string source, params object[] arguments)
    {
        return Translate(source, false, arguments);
    }

    public string Translate(string source, bool capitalize = false, params object[] arguments)
    {
        string result;
        if (LanguageFactory.Languages["en"]._reverseLookup.TryGetValue(source, out var translationId))
        {
             result = Translate(source, translationId);
        }
        else
        {
            result = _googleTranslateClient.Translate(source);
            if (arguments.Length > 0)
            {
                result = string.Format(result, arguments);
            }
        }

        if (capitalize)
        {
            result = Culture.TextInfo.ToTitleCase(result);
        }
        return result;
    }

    private string BuildDescription(string format, Dictionary<string, string> parameters)
    {
        if (format == null || parameters == null)
        {
            return format;
        }

        foreach (var parameter in parameters)
        {
            format = format.Replace("{" + parameter.Key + "}", parameter.Value);
        }

        return format;
    }
}