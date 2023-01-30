using System;
using System.ComponentModel;
using System.Globalization;

namespace MSiccDev.Libs.Maui.SystemIcons
{
	public sealed class SfSymbolsImageSourceConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			=> sourceType == typeof(string);

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			=> true;

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();
			if (strValue != null)
				return SfSymbolsImageSource.FromSymbolName(strValue);

			throw new InvalidOperationException($"Cannot convert {strValue} into {typeof(SfSymbolsImageSource)}");

		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not SfSymbolsImageSource symbolsImageSource)
				throw new NotSupportedException();

			return symbolsImageSource.SymbolName;
		}
	}
}

