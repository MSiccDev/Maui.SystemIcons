using System;
using System.Runtime.CompilerServices;

namespace MSiccDev.Libs.Maui.SystemIcons
{
	[System.ComponentModel.TypeConverter(typeof(SfSymbolsImageSourceConverter))]
	public sealed class SfSymbolsImageSource : ImageSource, ISfSymbolsImageSource
	{
		public static readonly BindableProperty SymbolNameProperty =
			BindableProperty.Create(nameof(SymbolName), typeof(string), typeof(SfSymbolsImageSource), default(string));

		public string SymbolName
		{
			get { return (string)GetValue(SymbolNameProperty); }
			set { SetValue(SymbolNameProperty, value); }
		}

		public override Task<bool> Cancel()
			=> Task.FromResult(false);

		public override string ToString()
			=> $"SymbolName: {this.SymbolName}";

		protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (propertyName == nameof(SymbolName))
				OnSourceChanged();

			base.OnPropertyChanged(propertyName);
		}

		public static ImageSource FromSymbolName(string symbolName)
		{
			return new SfSymbolsImageSource() { SymbolName = symbolName };
		}
	}
}

