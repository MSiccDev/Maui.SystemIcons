using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.UI.Xaml.Media.Imaging;
using WImageSource = Microsoft.UI.Xaml.Media.ImageSource;

namespace MSiccDev.Libs.Maui.SystemIcons
{
	public partial class SfSymbolsImageSourceService
	{
		public override Task<IImageSourceServiceResult<WImageSource>?> GetImageSourceAsync(IImageSource imageSource, float scale = 1, CancellationToken cancellationToken = default) =>
			throw new NotSupportedException("SFSymbols is not supported on Windows. Please use Segoe UI Symbols font.");
	}
}

