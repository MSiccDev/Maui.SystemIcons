#nullable enable
using System;
using Microsoft.Extensions.Logging;
using UIKit;

namespace MSiccDev.Libs.Maui.SystemIcons
{
	public partial class SfSymbolsImageSourceService
	{
		public override Task<IImageSourceServiceResult<UIImage>?> GetImageAsync(IImageSource imageSource, float scale = 1, CancellationToken cancellationToken = default)
			=> GetImageAsync((ISfSymbolsImageSource)imageSource, scale, cancellationToken);

		public Task<IImageSourceServiceResult<UIImage>?> GetImageAsync(ISfSymbolsImageSource imageSource, float scale = 1, CancellationToken cancellationToken = default)
		{
			if (imageSource == null)
				return FromResult(null);

			try
			{
				var image = imageSource.GetPlatformImage();

				if (image == null)
					throw new InvalidOperationException("Unable to load image from SfSymbol.");

				var result = new ImageSourceServiceResult(image, () => image.Dispose());

				return FromResult(result);
			}
			catch (Exception ex)
			{
				Logger?.LogWarning(ex, "Unable to find Symbol {SymbolName}", imageSource.SymbolName);
				throw;
			}
		}

		static Task<IImageSourceServiceResult<UIImage>?> FromResult(IImageSourceServiceResult<UIImage>? result) =>
			Task.FromResult(result);
	}
}

