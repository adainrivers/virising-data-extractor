using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Gaming.Tools.Shared.RouteLocalization
{
    [HtmlTargetElement("a", Attributes = ActionAttributeName)]
    [HtmlTargetElement("a", Attributes = ControllerAttributeName)]
    public class LanguageTagHelper : TagHelper
    {
        private const string ActionAttributeName = "asp-action";
        private const string ControllerAttributeName = "asp-controller";

        public override int Order => -999;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (output.Attributes.TryGetAttribute("href", out var hrefAttribute))
            {
                var href = (string)hrefAttribute.Value;
                href = href.EndsWith("/en") ? href.Remove(href.Length - 3, 3) : href.Replace("/en/", "/");
                output.Attributes.Remove(hrefAttribute);
                output.Attributes.Add("href", href);
            }

            base.Process(context, output);
        }
    }
}
