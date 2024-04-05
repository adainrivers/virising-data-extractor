using System;
using System.Collections.Generic;
using VRising.Localization;
using VRising.Models.Helpers;

namespace VRising.Models.Localization;

public class LocalizedResource
{
    public LocalizedResource(string key, string text, Dictionary<string, string> parameters = null)
    {
        Text = text;
        Parameters = parameters;
        Key = key.ToGuid();
    }

    public string Text { get; }
    public Guid Key { get; }

    public Dictionary<string, string> Parameters { get; }

    public string Translate(Language language) => language.Translate(Text, Key, Parameters);
}