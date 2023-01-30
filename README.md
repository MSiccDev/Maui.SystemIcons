# MSiccDev.Libs.Maui.SystemIcons

## Purpose
This helper library makes it easier to access system symbols in .NET MAUI.

Currently supported:
- iOS: SF Symbols
- MacCatalys: SF Symbols

Coming soon:
- Windows (MDL2 Assets)
- Windows (Segoe UI Symbol)
- Android (via MaterialDesignIcons font)

For all other platforms, there are no plans right now.

## Init

1. Register the CommunityToolkit
2. Register the FontSourceService(s)

```csharp
using CommunityToolkit.Maui;
using MSiccDev.Libs.Maui.SystemIcons;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			// Initialize the .NET MAUI Community Toolkit by adding the below line(s) of code
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
			// Register the custom FontSourceServices:
			.ConfigureImageSources(services =>
			{
				services.AddService<ISfSymbolsImageSource, SfSymbolsImageSourceService>();
			});

		// Continue initializing your .NET MAUI App here

		return builder.Build();
	}
}
```

## XAML usage:
On any View that has an `ImageSource` proeprty, use the following:
```xml
xmlns:systemicons="clr-namespace:MSiccDev.Libs.Maui.SystemIcons;assembly=MSiccDev.Libs.Maui.SystemIcons"

<Image HorizontalOptions="Center" HeightRequest="48" WidthRequest="48" Margin="8"
       Source="{OnPlatform MacCatalyst={systemicons:SfSymbolsImageSource SymbolName='house.fill'},
                           iOS={systemicons:SfSymbolsImageSource SymbolName='house.fill'}}">
</Image>
```
Please note that the `OnPlatform` usage is mandatory as the icons have different names on all platforms. 
There are no plans to create a common naming scheme at the moment.

## Coloring
[Apple recommends to apply configurations (in which coloring falls) to the UIImageView](https://developer.apple.com/documentation/uikit/uiimage/configuring_and_displaying_symbol_images_in_your_ui).

As we are NOT drawing directly in this implementation,
we simply fall back to the coloring of the CommunityToolkit
(there is no need to reinvent the wheel, and we are going to use it, anyways)

``` xml
xmlns:toolkit="http://schemas.microsoft.com/dotnet/2022/maui/toolkit"

<Image.Behaviors>
    <toolkit:IconTintColorBehavior TintColor="HotPink" />
</Image.Behaviors>
```
