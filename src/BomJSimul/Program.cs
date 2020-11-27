namespace BomJSimul
{
    using System;
    using System.Reflection;
    using BomJSimul.Engine;
    using BomJSimul.Render;
    using Catel.IoC;
    using Catel.Logging;
    using Terminal.Gui;

    public class Program
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        private static void Main(string[] args)
        {
            try
            {
                CompositionRoot.Initialize();

                // Test
                var t = new BomJSimul.GameLogic.PlayerOpenContainerInteraction();
                Console.WriteLine(t.GetRandomItem());

                // Start game loop
                var mainLoop = new GameLoop();

                var serviceLocator = ServiceLocator.Default;
                var renderer = serviceLocator.ResolveType<IConsoleService>();
                renderer.InitializeAndShowMainScreen();
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }
    }
}
