using System;
using Microsoft.Extensions.Logging;

namespace MSiccDev.Libs.Maui.SystemIcons
{
	public partial class SfSymbolsImageSourceService : ImageSourceService, IImageSourceService<ISfSymbolsImageSource>
	{
		public SfSymbolsImageSourceService()
			:this(null)
		{

		}

		public SfSymbolsImageSourceService(ILogger<SfSymbolsImageSourceService> logger = null) : base(logger)
		{
		}
	}
}

