namespace BomJSimul
{
    using System;
    using System.Reflection;
    using BomJSimul.Engine;
    using BomJSimul.GameLogic;
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

                var r = new BomJSimul.GameLogic.PlayerUsesSlotMachine();
                var player = new Entities.Player();
                player.Money = 100;
                player.Luck.Update(100);
                Console.WriteLine(r.TryingToWinMoney(player, 10, 20));
                Console.WriteLine($"Ваши деньги: {player.Money}");
                Console.WriteLine($"Ваша удача: {player.Luck.Level}");

                var f = new BegForMoney();
                f.GiveMeMoney(player, 100);

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
