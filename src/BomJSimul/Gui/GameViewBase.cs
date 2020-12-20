namespace BomJSimul.Gui
{
    using BomJSimul.Gui.Consoles.GameViewContentConsole;
    using BomJSimul.Gui.Sad.Colors;
    using BomJSimul.Text;
    using Microsoft.Xna.Framework;
    using SadConsole;

    public class GameViewBase : Console
    {
        public GameViewBase(Console parentConsole, string title = null, int width = 300, int height = 200)
            : base(width, height)
        {
            UsePrintProcessor = true;

            this.Parent = parentConsole;

            var backgroundColor = Color.Blue;
            var foregroundColor = Color.White;
            var borderColor = Color.White;

            this.Fill(foregroundColor, backgroundColor, 0);

            InnerConsole = new GameViewContentConsole(width - 2, height - 2);
            InnerConsole.Position = new Point(this.Position.X + 1, this.Position.Y + 1);

            // Use custom colors
            InnerConsole.ThemeColors = new GameViewColors();

            Fill(foregroundColor, backgroundColor, 0);

            InnerConsole.Parent = this;

            InnerConsole.Fill(foregroundColor, Color.LightBlue, 0);

            // Border & Header
            this.DrawBorders(width, height, borderColor, backgroundColor);
            DrawHeader(title, foregroundColor);
        }

        protected ControlsConsole InnerConsole { get; set; }

        protected virtual void DrawHeader(string str, Color foreground)
        {
            var translatedHeader = Transliteration.From(str);

            Print(2, 0, $" [c:g f:MediumPurple:Red:{translatedHeader.Length}]{translatedHeader} ");
        }
    }
}
