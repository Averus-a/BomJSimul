namespace BomJSimul.Gui.Sad
{
    using BomJSimul.Text;
    using Microsoft.Xna.Framework;
    using SadConsole;
    using SadConsole.Controls;

    internal class GameGraphicsView : GameViewBase
    {
        public GameGraphicsView(Console mainConsole, string title = null, int width = 300, int height = 200)
            : base(mainConsole, title, width, height)
        {
            DrawText(InnerConsole);
        }

        private void DrawText(ControlsConsole innerConsole)
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
