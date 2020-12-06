namespace BomJSimul.Gui.Sad
{
    using BomJSimul.Text;
    using Microsoft.Xna.Framework;
    using SadConsole;

    internal class GameGraphicsView : Console
    {
        private ControlsConsole _innerConsole;

        public GameGraphicsView(Console mainConsole, string title = null, int width = 300, int height = 200)
            : base(width, height)
        {
            UsePrintProcessor = true;

            this.Parent = mainConsole;

            var backgroundColor = Color.Blue;
            var foregroundColor = Color.White;
            var borderColor = Color.White;

            this.Fill(foregroundColor, backgroundColor, 0);

            _innerConsole = new ControlsConsole(width - 2, height - 2);
            _innerConsole.Position = new Point(this.Position.X + 1, this.Position.Y + 1);

            Fill(foregroundColor, backgroundColor, 0);

            _innerConsole.Parent = this;

            _innerConsole.Fill(foregroundColor, Color.LightBlue, 0);

            // Border & Header
            this.DrawBorders(width, height, borderColor, backgroundColor);
            DrawHeader(title, foregroundColor);
            DrawText(_innerConsole, foregroundColor);
        }

        private void DrawHeader(string str, Color foreground)
        {
            var translatedHeader = Transliteration.From(str);

            Print(2, 0, $" [c:g f:MediumPurple:Red:{translatedHeader.Length}]{translatedHeader} ");

        }

        private void DrawText(Console _innerConsole, Color foreground)
        {
            var r = new BomJSimul.GameLogic.PlayerUsesSlotMachine();
            var player = new Entities.Player();
            player.Money = 100;
            player.Luck.Level = 100;
            _innerConsole.Print(1, 0, $"{r.TryingToWinMoney(player, 10, 20)}");
            _innerConsole.Print(1, 4, Transliteration.From($"Ваши деньги: {player.Money}"));
            _innerConsole.Print(1, 5, Transliteration.From($"Ваша удача: {player.Luck.Level}"));
            _innerConsole.Print(1, 6, Transliteration.From($"сяськи мосяськи "));
        }
    }
}
