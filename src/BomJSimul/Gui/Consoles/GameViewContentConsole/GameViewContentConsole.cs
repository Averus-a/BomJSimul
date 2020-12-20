namespace BomJSimul.Gui.Consoles.GameViewContentConsole
{
    using BomJSimul.Gui.Consoles.GameViewContentConsole.Renderers;
    using SadConsole;
    using System;

    public class GameViewContentConsole : ControlsConsole
    {
        public GameViewContentConsole(int width, int height)
            : base(width, height)
        {
            Renderer = new GameViewConentConsoleRenderer();
        }

        public GameViewContentConsole(int width, int height, Font font)
            : base(width, height, font)
        {
            Renderer = new GameViewConentConsoleRenderer();
        }

        public override void Draw(TimeSpan update)
        {
            base.Draw(update);
        }
    }
}
