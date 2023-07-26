using CommunityToolkit.Maui;
using DemoApp.Configuration;
using Microsoft.Extensions.Logging;

namespace DemoApp;

public static class MauiProgram
{
	public static IServiceProvider Services;
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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services
			.AddServices()
			.AddUIComponents();
		
		var builtApp = builder.Build();

		Services = builtApp.Services;

        return builtApp;
	}
}
