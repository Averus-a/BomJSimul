﻿namespace BomJSimul.Gui.Sad
{
    using Microsoft.Xna.Framework;
    using SadConsole;

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
            this.Parent = mainConsole;

            var backgroundColor = Color.Blue;
            var foregroundColor = Color.White;

            var borderColor = Color.White;

            this.Fill(new Rectangle(new Point(0, 0), new Point(width, height)), Color.White, Color.Blue, 0);

            _innerConsole = new Console(width - 1, height - 1);

            FillColor(this, backgroundColor, foregroundColor);

            _innerConsole.Parent = this;

            FillColor(_innerConsole, Color.Yellow, foregroundColor);

            // Border & Header
            DrawLine(new Point(0, 0), new Point(200, 0), borderColor, borderColor);
        }

        private void FillColor(Console console, Color background, Color foreground)
        {
            console.Fill(new Rectangle(new Point(0, 0), new Point(console.Width, console.Height)), foreground, background, 0);
        }
    }
}
