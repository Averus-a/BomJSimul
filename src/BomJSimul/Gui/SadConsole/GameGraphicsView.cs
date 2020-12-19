namespace BomJSimul.Gui.Sad
{
    using BomJSimul.Gui.Sad.Colors;
    using BomJSimul.Text;
    using Microsoft.Xna.Framework;
    using SadConsole;
    using SadConsole.Controls;

    internal class GameGraphicsView : Console
    {
        private readonly ControlsConsole _innerConsole;

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

            // Use custom colors
            _innerConsole.ThemeColors = new GameViewColors();

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

        private void DrawText(ControlsConsole innerConsole, Color foreground)
        {
            var r = new BomJSimul.GameLogic.PlayerUsesSlotMachine();
            
            var player = new Entities.Player
            {
                Money = 100
            };

            player.Luck.Update(100);
            innerConsole.Print(1, 0, $"{r.TryingToWinMoney(player, 10, 20)}");

            var label1 = new Label(Transliteration.From($"Ваши деньги: {player.Money}"));
            var label2 = new Label(Transliteration.From($"Ваша удача: {player.Luck.Level}"));
            var label3 = new Label(Transliteration.From($"сяськи мосяськи "));

            label1.Position = new Point(1, 4);
            label2.Position = new Point(1, 5);
            label3.Position = new Point(1, 6);

            innerConsole.Add(label1);
            innerConsole.Add(label2);
            innerConsole.Add(label3);
        }
    }
}
