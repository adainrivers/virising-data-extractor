using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Gaming.Tools.Shared.RouteLocalization
{
    public static class LocalizationConfiguration
    {
        public static IServiceCollection AddSimpleLocalization(this IServiceCollection services, ILanguageCodesFactory languageFactory)
        {
            services.AddScoped<CurrentLanguage>();
            services.AddSingleton(languageFactory);

            return services;
        }

        public static IApplicationBuilder UseSimpleLocalization(this IApplicationBuilder app)
        {
            app.UseMiddleware<RouteLanguageMiddleware>();
            return app;
        }
    }
}
