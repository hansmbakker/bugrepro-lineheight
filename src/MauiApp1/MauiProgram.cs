using Microsoft.Extensions.Logging;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigurePoppinsFonts();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        private static MauiAppBuilder ConfigurePoppinsFonts(this MauiAppBuilder builder)
        => builder.ConfigureFonts(fonts
            => fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular")
                .AddFont("Poppins-SemiBold.ttf", "PoppinsSemiBold"));
    }
}
