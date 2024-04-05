using System;
using VRising.Localization;

namespace VRising.Models.Data
{
    public class LocalizedString
    {
        public Guid Key { get; set; }
        public string Value { get; set; }

        public string Translate(Language language) => language.Translate(Value, Key);
    }
}