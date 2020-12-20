namespace BomJSimul.Gui.Sad.Themes
{
    using SadConsole;

    public class GameViewHostConsoleTheme : SadConsole.Themes.ControlsConsoleTheme
    {
        public override void Draw(ControlsConsole console, CellSurface hostSurface)
        {
            var textColor = console.ThemeColors;

            base.Draw(console, hostSurface);
        }
    }
}
