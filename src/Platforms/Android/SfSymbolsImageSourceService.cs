using System;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Widget;

namespace MSiccDev.Libs.Maui.SystemIcons
{
	public partial class SfSymbolsImageSourceService
	{
		public override Task<IImageSourceServiceResult<Drawable>> GetDrawableAsync(IImageSource imageSource, Context context, CancellationToken cancellationToken = default) =>
			throw new NotSupportedException("SF Symbols is not supported on Android. Please use a custom font (e.g. MaterialDesignIcons)");

		public override Task<IImageSourceServiceResult> LoadDrawableAsync(IImageSource imageSource, ImageView imageView, CancellationToken cancellationToken = default) =>
			base.LoadDrawableAsync(imageSource, imageView, cancellationToken);
	}
}

