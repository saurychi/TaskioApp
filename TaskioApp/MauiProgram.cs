using Microsoft.Extensions.Logging;
using Microsoft.Maui.Handlers;

namespace TaskioApp;

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
                fonts.AddFont("Poppins-Black.ttf", "PoppinsBold");
                fonts.AddFont("Poppins-Regular.ttf", "Poppins");
                fonts.AddFont("InriaSans-Regular.ttf", "InriaSans");
                fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons");
            });

        EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
        {
#if ANDROID
            handler.PlatformView.Background = null;
#endif
        });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
