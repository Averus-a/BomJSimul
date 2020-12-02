﻿namespace BomJSimul.Gui.Sad
{
    using BomJSimul.Text;
    using Microsoft.Xna.Framework;
    using SadConsole;

    internal class GameGraphicsView : Console
    {
        private Console _innerConsole;

        public GameGraphicsView(Console mainConsole, string title = null, int width = 300, int height = 200)
            : base(width, height)
        {
            UsePrintProcessor = true;

            this.Parent = mainConsole;

            var backgroundColor = Color.Blue;
            var foregroundColor = Color.White;
            var borderColor = Color.White;

            this.Fill(Color.White, Color.Blue, 0);

            _innerConsole = new Console(width - 2, height - 2);
            _innerConsole.Position = new Point(this.Position.X + 1, this.Position.Y + 1);

            Fill(foregroundColor, backgroundColor, 0);

            _innerConsole.Parent = this;

            _innerConsole.Fill(foregroundColor, Color.LightBlue, 0);

            // Border & Header
            this.DrawBorders(width, height, borderColor, backgroundColor);
            DrawHeader(title, foregroundColor);
        }

        private void DrawHeader(string str, Color foreground)
        {
            var translatedHeader = Transliteration.Front(str);

            Print(2, 0, $" [c:g f:MediumPurple:Red:{translatedHeader.Length}]{translatedHeader} ");
        }
    }
}
