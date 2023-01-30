using System;
namespace MSiccDev.Libs.Maui.SystemIcons
{
	public class SfSymbolsImageSourceMarkupExtension : IMarkupExtension<ImageSource>
	{
		public string SymbolName { get; set; }

		public ImageSource ProvideValue(IServiceProvider serviceProvider) =>
			SfSymbolsImageSource.FromSymbolName(this.SymbolName);

		object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) =>
			(this as IMarkupExtension<ImageSource>).ProvideValue(serviceProvider);
	}
}

