using Microsoft.Extensions.Logging;
using PhotoExplorer.Components.Services;
using PhotoExplorer.Explorer.Services;

namespace PhotoExplorer.Mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddScoped<IPhotoService, HybridPhotoService>();
            builder.Services.AddScoped<HttpClient>(_ => new HttpClient());

            return builder.Build();
        }
    }
}
