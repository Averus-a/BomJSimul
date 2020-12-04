namespace BomJSimul.Gui.Sad
{
    using Microsoft.Xna.Framework;
    using SadConsole;

    internal class FooterMenuView : Console
    {
        public FooterMenuView(Console mainConsole, int height)
                : base(mainConsole.Width, height)
        {
            this.Parent = mainConsole;

            var backgroundColor = Color.DarkGray;
            var foregroundColor = Color.White;

            this.Fill(foregroundColor, backgroundColor, 0);
        }
    }
}
