using GymPal.Pages;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Platform;
using GymPal.ViewModels;

namespace GymPal
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
			builder.Services.AddSingleton<SharedViewModel>();

			builder.Services.AddSingleton<MainPage>();
			builder.Services.AddSingleton<LogsView>();
			builder.Services.AddSingleton<BodyWeight2>();
			
			builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("Jost-ExtraBold.ttf","JostExtraBold");
                    fonts.AddFont("Jost-Bold.ttf", "JostBold");
                    fonts.AddFont("Jost-SemiBold.ttf", "JostSemiBold");

                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
