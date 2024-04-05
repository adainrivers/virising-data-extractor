using Microsoft.AspNetCore.Http;

namespace Gaming.Tools.Shared.RouteLocalization
{
    public class RouteLanguageMiddleware
    {
        private readonly RequestDelegate _next;

        public RouteLanguageMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, CurrentLanguage currentLanguage, ILanguageCodesFactory languageFactory)
        {
            var path = context.Request.Path.Value;
            if (path == null)
            {
                await _next(context);
                return;
            }

            var language = languageFactory.FirstOrDefault(languageValue => path.Equals($"/{languageValue}") || path.StartsWith($"/{languageValue}/"));
            currentLanguage.OriginalPathBase = context.Request.PathBase;
            if (language != null)
            {
                context.Request.PathBase += "/" + language;
                path = path.Remove(0, language.Length + 1);
                if (!path.StartsWith("/"))
                {
                    path = "/" + path;
                }
                context.Request.Path = path;
            }
            else
            {
                language = languageFactory.DefaultLanguageCode;
            }

            currentLanguage.Code = language;
            await _next(context);
        }
    }
}
