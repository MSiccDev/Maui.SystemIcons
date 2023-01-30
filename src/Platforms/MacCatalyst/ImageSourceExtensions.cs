#nullable enable
using System;
using Microsoft.Maui.Platform;
using UIKit;

namespace MSiccDev.Libs.Maui.SystemIcons
{
	public static partial class ImageSourceExtensions
	{
		public static UIImage? GetPlatformImage(this MSiccDev.Libs.Maui.SystemIcons.ISfSymbolsImageSource imageSource)
			=> UIKit.UIImage.GetSystemImage(imageSource.SymbolName);
	}
}

