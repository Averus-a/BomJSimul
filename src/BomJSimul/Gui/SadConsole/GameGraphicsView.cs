namespace BomJSimul.Gui.Sad
{
    using BomJSimul.Text;
    using Microsoft.Xna.Framework;
    using SadConsole;
    using System.Text;

    internal class GameGraphicsView : Console
    {
        private Console _innerConsole;

        public GameGraphicsView(string title = null, int width = 300, int height = 200)
            : base(width, height)
        {

        }

        public GameGraphicsView(Console mainConsole, string title = null, int width = 300, int height = 200)
            : base(width, height)
        {
            UsePrintProcessor = true;

            this.Parent = mainConsole;

            var backgroundColor = Color.Blue;
            var foregroundColor = Color.White;
            var borderColor = Color.White;

            this.Fill(new Rectangle(new Point(0, 0), new Point(width, height)), Color.White, Color.Blue, 0);

            _innerConsole = new Console(width - 2, height - 2);
            _innerConsole.Position = new Point(this.Position.X + 1, this.Position.Y + 1);

            FillColor(this, backgroundColor, foregroundColor);

            _innerConsole.Parent = this;

            FillColor(_innerConsole, Color.Yellow, foregroundColor);

            // Border & Header
            DrawBorders(width, height, borderColor, backgroundColor);
            DrawHeader(title, foregroundColor);
        }

        private void FillColor(Console console, Color background, Color foreground)
        {
            console.Fill(new Rectangle(new Point(0, 0), new Point(console.Width, console.Height)), foreground, background, 0);
        }

        private void DrawBorders(int width, int height, Color foreground, Color background)
        {
            // 179 - vertical line
            // 186 - horizontal line
            DrawLine(new Point(0, 0), new Point(0, height), foreground, background, 179); // Left side
            DrawLine(new Point(width - 1, 0), new Point(width - 1, height - 1), foreground, background, 179); // Right side

            DrawLine(new Point(0, 0), new Point(width, 0), foreground, background, 196);
            DrawLine(new Point(0, height - 1), new Point(width - 1, height - 1), foreground, background, 196);

            // Angles
            SetGlyph(0, 0, 218); // Left-top
            SetGlyph(width - 1, 0, 191); // Right-top
            SetGlyph(0, height - 1, 192); // Left-bottom
            SetGlyph(width - 1, height - 1, 217); // Right-bottom
        }

        private void DrawHeader(string str, Color foreground)
        {
            var translatedHeader = Transliteration.Front(str);

            Print(2, 0, $" [c:g f:MediumPurple:Red:{translatedHeader.Length}]{translatedHeader} ");
        }
    }
}
