namespace BomJSimul.Render
{
    using System.Reflection;
    using BomJSimul.Gui.Sad;
    using BomJSimul.Gui.Sad.Themes;
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
            var headerMenuHeight = 1;
            var footerMenuHeight = 1;

            SadConsole.Themes.Library.Default.SetControlTheme(typeof(MenuItem), new MenuItemGenericTheme());

            var mainScreen = new Console(screenWidth, screenHeight);

            mainScreen.Fill(new Rectangle(new Point(0, 0), new Point(screenWidth, screenHeight)), Color.White, Color.DarkBlue, 0);

            var graphicsView = new GameGraphicsView(mainScreen, $"Симулятор Бомжа v{version}", screenWidth * 2 / 3, screenHeight * 3 / 4 - headerMenuHeight);

            var infoView = new GameInfoView(mainScreen, "Информация", screenWidth * 1 / 3, screenHeight * 3 / 4 - headerMenuHeight);

            var logView = new GameLogView(mainScreen, "Сообщения", screenWidth, screenHeight * 1 / 4 - footerMenuHeight);

            int infoViewOffsetX = 0;
            int logViewOffsetY = 0;

            graphicsView.Position = new Point(0, 0 + headerMenuHeight);
            infoView.Position = new Point(graphicsView.Position.X + graphicsView.Width + infoViewOffsetX, 0 + headerMenuHeight);
            logView.Position = new Point(0, graphicsView.Position.Y + graphicsView.Height + logViewOffsetY);
            
            // menus
            var topMenu = new HeaderMenuView(mainScreen, headerMenuHeight);
            topMenu.AddMenu(new MenuItem("Игра"));
            topMenu.AddMenu(new MenuItem("Настройки"));
            topMenu.AddMenu(new MenuItem("О программе"));
            topMenu.AttachMenu();

            var footerMenu = new FooterMenuView(mainScreen, footerMenuHeight);
            footerMenu.Position = new Point(0, screenHeight - footerMenuHeight);
            footerMenu.AddMenu(new MenuItem("F1 Помощь"));
            footerMenu.AddMenu(new MenuItem("F2 Загрузить"));
            footerMenu.AddMenu(new MenuItem("F3 Сохранить"));
            footerMenu.AddMenu(new MenuItem("Q Выход"));
            footerMenu.AttachMenu();

            return mainScreen;
        }
    }
}
