namespace BomJSimul.Gui.Sad.Colors
{
    using System.Collections.Generic;
    using BomJSimul.Gui.Converters;

    public class GameViewColors : SadConsole.Themes.Colors
    {
        private readonly Dictionary<string, string> _knownColors = new Dictionary<string, string>();

        private readonly XnaColorToStringConverter _toStringConverter = new XnaColorToStringConverter();

        public GameViewColors()
        {
            // Use ctor to set non-standard colors for custom theme
            Text = Microsoft.Xna.Framework.Color.RoyalBlue;
            ControlBack = Microsoft.Xna.Framework.Color.Blue;

            _knownColors.Add(nameof(TitleText), _toStringConverter.Convert(TitleText));
            _knownColors.Add(nameof(Lines), _toStringConverter.Convert(Lines));
            _knownColors.Add(nameof(TextBright), _toStringConverter.Convert(TextBright));
            _knownColors.Add(nameof(Text), _toStringConverter.Convert(Text));
            _knownColors.Add(nameof(TextSelected), _toStringConverter.Convert(TextSelected));
            _knownColors.Add(nameof(TextSelectedDark), _toStringConverter.Convert(TextSelectedDark));
            _knownColors.Add(nameof(TextLight), _toStringConverter.Convert(TextLight));
            _knownColors.Add(nameof(TextDark), _toStringConverter.Convert(TextDark));
            _knownColors.Add(nameof(TextFocused), _toStringConverter.Convert(TextFocused));
            _knownColors.Add(nameof(ControlBack), _toStringConverter.Convert(ControlBack));
            _knownColors.Add(nameof(ControlBackLight), _toStringConverter.Convert(ControlBackLight));
            _knownColors.Add(nameof(ControlBackSelected), _toStringConverter.Convert(ControlBackSelected));
            _knownColors.Add(nameof(ControlBackDark), _toStringConverter.Convert(ControlBackDark));
            _knownColors.Add(nameof(ControlHostBack), _toStringConverter.Convert(ControlHostBack));
            _knownColors.Add(nameof(ControlHostFore), _toStringConverter.Convert(ControlHostFore));
            _knownColors.Add(nameof(ModalBackground), _toStringConverter.Convert(ModalBackground));

            RebuildAppearances();
        }
    }
}
