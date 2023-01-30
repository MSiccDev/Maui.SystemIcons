using CommunityToolkit.Maui;
using MSiccDev.Libs.Maui.SystemIcons;

namespace SystemIconsSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit(options =>
			{
				options.SetShouldSuppressExceptionsInConverters(false);
				options.SetShouldSuppressExceptionsInBehaviors(false);
				options.SetShouldSuppressExceptionsInAnimations(false);
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureImageSources(services =>
			{
				services.AddService<ISfSymbolsImageSource, SfSymbolsImageSourceService>();
			});

		return builder.Build();
	}
}

