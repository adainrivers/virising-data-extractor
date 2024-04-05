using System.Collections;
using Gaming.Tools.Shared.RouteLocalization;

namespace VRising.Localization;

public class LanguageCodesFactory : ILanguageCodesFactory
{
    private static readonly HashSet<string> Languages = LanguageFactory.Languages.Keys.ToHashSet();

    public IEnumerator<string> GetEnumerator()
    {
        return Languages.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public string DefaultLanguageCode => "en";
}