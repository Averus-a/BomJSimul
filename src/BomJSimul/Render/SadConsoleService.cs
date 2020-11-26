namespace BomJSimul.Render
{
    using BomJSimul.Gui.Sad;
    using Microsoft.Xna.Framework;
    using SadConsole;
    using System.Reflection;

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

            var graphicsView = new GameGraphicsView(mainScreen, $"Симулятор Бомжа v{version}", screenWidth * 2 / 3, screenHeight * 3 / 4);

            //var infoView = new GameInfoView("Сообщения", 40, 15);
            //infoView.Fill(Color.Violet, Color.AliceBlue, 0);
            //infoView.Print(4, 4, "Cообщения");

            //var logView = new GameLogView("Информация", 60, 3);
            //logView.Fill(Color.Black, Color.DarkBlue, 0);
            //logView.Print(4, 4, "Информация");

            graphicsView.Parent = mainScreen;
            //infoView.Parent = mainScreen;
            //logView.Parent = mainScreen;

            return mainScreen;
        }
    }
}
