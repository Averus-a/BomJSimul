namespace BomJSimul.Gui.Sad
{
    using Microsoft.Xna.Framework;
    using SadConsole;

    internal class FooterMenuView : Console
    {
        public FooterMenuView(Console mainConsole, int height)
                : base(mainConsole.Width, height)
        {
            var backgroundColor = Color.Blue;
            var foregroundColor = Color.White;
            var borderColor = Color.White;

            this.Fill(Color.White, Color.Blue, 0);


        }
    }
}
