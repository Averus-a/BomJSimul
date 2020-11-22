namespace BomJSimul.Render
{
    using System;
    using System.Reflection;
    using Terminal.Gui;

    internal class GuiCsService : IConsoleService
    {
        public void InitializeAndShowMainScreen()
        {
            var app = Initialize();
            Terminal.Gui.Application.Run(app);
        }

        private Toplevel Initialize()
        {
            Application.Init();

            // TODO: Create custom color shemas
            // TODO: Fix resize bug or set main window fullscreen

            var toplLayer = Terminal.Gui.Application.Top;

            var version = Assembly.GetExecutingAssembly().GetName().Version;

            var gameGraphics = new BomJSimul.Gui.GuiCs.GameGraphicsView($"Симулятор Бомжа v{version}")
            {
                X = 0,
                Y = 0,
                Width = Dim.Percent(66),
                Height = Dim.Percent(75),
            };

            var gameLog = new BomJSimul.Gui.GuiCs.GameLogView($"Сообщения")
            {
                X = 0,
                Y = Pos.Percent(77),
                Width = Dim.Percent(66),
                Height = Dim.Fill(0),
            };

            var gameInfo = new BomJSimul.Gui.GuiCs.GameInfoView($"Информация")
            {
                X = Pos.Percent(66),
                Y = 0,
                Width = Dim.Fill(0),
                Height = Dim.Fill(0),
            };

            var menu = new MenuBar(
                new MenuBarItem[]
                {
                    new MenuBarItem("_Game", new MenuItem[]
                    {
                        new MenuItem("_Start", string.Empty, () => Console.WriteLine("Menu button pressed: Start")),
                        new MenuItem("_Exit", string.Empty, () => Console.WriteLine("Menu button pressed: Exit"))
                    }),

                    new MenuBarItem("_Edit", new MenuItem[]
                    {
                        new MenuItem("_Options", string.Empty, () => Console.WriteLine("Menu button pressed: Start")),
                    })
                });

            toplLayer.Add(menu);
            toplLayer.Add(gameGraphics);
            toplLayer.Add(gameLog);
            toplLayer.Add(gameInfo);

            return toplLayer;
        }
    }
}
