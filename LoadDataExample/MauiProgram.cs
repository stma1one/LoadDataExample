using LoadDataExample.Service;
using LoadDataExample.ViewModels;
using LoadDataExample.Views;
using Microsoft.Extensions.Logging;

namespace LoadDataExample
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
            builder.Services.AddSingleton<TriviaService>();
            builder.Services.AddSingleton<QuestionPageViewModel>();
            builder.Services.AddSingleton<QuestionPage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
