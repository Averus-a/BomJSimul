namespace BomJSimul.Gui.Converters
{
    using System;
    using Catel.MVVM.Converters;
    using Microsoft.Xna.Framework;

    public class XnaColorToStringConverter : ValueConverterBase<Color, string>
    {
        public string Convert(Color value)
        {
            return (string)Convert(value, typeof(string), null);
}

        protected override object Convert(Color value, Type targetType, object parameter)
        {
            System.Drawing.Color newClrColor = System.Drawing.Color.FromArgb(value.A, value.R, value.G, value.B);
            System.Drawing.KnownColor kColor = newClrColor.ToKnownColor();
            var colorName = kColor != 0 ? kColor.ToString() : string.Empty;

            return colorName;
        }
    }
}
