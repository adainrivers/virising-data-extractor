namespace VRising.Localization
{
    public class Translator
    {
        private readonly LanguageFactory _languageFactory;

        public Translator(LanguageFactory languageFactory)
        {
            _languageFactory = languageFactory;
        }

        public Language Current => _languageFactory.Current;
        public string this[string source, bool capitalize = true,  params string[] args] => _languageFactory.Current.Translate(source, capitalize, args);

    }
}
