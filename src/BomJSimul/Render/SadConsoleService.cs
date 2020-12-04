namespace BomJSimul.Render
{
    using System.Reflection;
    using BomJSimul.Gui.Sad;
    using Microsoft.Xna.Framework;
    using SadConsole;

    public class SadConsoleService : IConsoleService
    {
        public void InitializeAndShowMainScreen()
        {
            int screenWidth = 120;
            int screenHeight = 40;

            SadConsole.Game.Create(screenWidth, screenHeight);
            SadConsole.Game.OnInitialize = () => SadConsole.Global.CurrentScreen = Initialize(screenWidth, screenHeight);
            SadConsole.Game.Instance.Run();

        }

        private static Console Initialize(int screenWidth, int screenHeight)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            var mainScreen = new Console(screenWidth, screenHeight);
            mainScreen.Fill(new Rectangle(new Point(0, 0), new Point(screenWidth, screenHeight)), Color.White, Color.DarkBlue, 0);

            var graphicsView = new GameGraphicsView(mainScreen, $"Симулятор Бомжа v{version}", screenWidth * 2 / 3, screenHeight * 3 / 4 - 1);

            var infoView = new GameInfoView(mainScreen, "Информация", screenWidth, screenHeight * 1 / 4);

            var logView = new GameLogView(mainScreen, "Сообщения", screenWidth * 1 / 3, screenHeight * 3 / 4);

            int infoViewOffsetY = 0;
            int logViewOffsetX = 0;

            infoView.Position = new Point(0, graphicsView.Position.Y + graphicsView.Height + infoViewOffsetY);
            logView.Position = new Point(graphicsView.Position.X + graphicsView.Width + logViewOffsetX, 0);

            // menus
            var topMenu = new HeaderMenuView(mainScreen, 1);
            topMenu.Add(new MenuItem("Игра"));
            topMenu.Add(new MenuItem("Настройки"));
            topMenu.Add(new MenuItem("О программе"));
            topMenu.DrawMenu();

            return mainScreen;
        }
    }
}
