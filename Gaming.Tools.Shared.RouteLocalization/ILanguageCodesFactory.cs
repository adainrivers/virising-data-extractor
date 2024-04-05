namespace Gaming.Tools.Shared.RouteLocalization;

public interface ILanguageCodesFactory : IEnumerable<string>
{
    string DefaultLanguageCode { get; }
}