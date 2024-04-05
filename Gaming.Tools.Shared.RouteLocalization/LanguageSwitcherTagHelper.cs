using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Gaming.Tools.Shared.RouteLocalization;

[HtmlTargetElement("ls", Attributes = LanguageAttributeName)]
public class LanguageSwitcherTagHelper : TagHelper
{
    private readonly IHtmlGenerator _generator;
    private readonly CurrentLanguage _currentLanguage;
    private const string LanguageAttributeName = "language";

    public LanguageSwitcherTagHelper(IHtmlGenerator generator, CurrentLanguage currentLanguage)
    {
        _generator = generator;
        _currentLanguage = currentLanguage;
    }

    [HtmlAttributeName(LanguageAttributeName)]
    public string Language { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Microsoft.AspNetCore.Mvc.Rendering.ViewContext"/> for the current request.
    /// </summary>
    [HtmlAttributeNotBound]
    [ViewContext]
    public ViewContext ViewContext { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "a";

        var currentLanguageBase = _currentLanguage.Code == "en" ? string.Empty : "/" + _currentLanguage.Code;
        var targetLanguageBase = Language == "en" ? string.Empty : "/" + Language;

        // /vrising
        // /

        var pathBase = ViewContext.HttpContext.Request.PathBase.Value;
        if (currentLanguageBase == string.Empty)
        {
            pathBase += targetLanguageBase;
        }
        else
        {
            pathBase = pathBase.Replace(currentLanguageBase, string.Empty) + targetLanguageBase;
        }

        var path = pathBase + ViewContext.HttpContext.Request.Path.Value;



        output.Attributes.Add("href", path);
        output.Attributes.Add("data-language", Language);

    }
}