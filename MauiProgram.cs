
using Microsoft.Extensions.Logging;
using AlchemyByKirill_v_sqllite.ViewModels;
using AlchemyByKirill_v_sqllite.Views;

namespace AlchemyByKirill_v_sqllite
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
                

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<StartViewModel>();
            builder.Services.AddTransient<StartPage>();

            builder.Services.AddSingleton<GameViewModel>();
            builder.Services.AddSingleton<GamePage>();

            builder.Services.AddSingleton<LibraryViewModel>();
            builder.Services.AddSingleton<LibraryPage>();

            builder.Services.AddSingleton<RulesViewModel>();
            builder.Services.AddSingleton<RulesPage>();



            return builder.Build();
        }
    }
}