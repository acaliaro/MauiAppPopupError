using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace MauiAppPopupError
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                           .UseMauiCommunityToolkit()
 .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<MainPage, MainPageViewModel>();
            builder.Services.AddTransientWithShellRoute<NewPage1, NewPageViewModel>(nameof(NewPage1));


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}