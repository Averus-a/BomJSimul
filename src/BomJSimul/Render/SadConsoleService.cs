namespace BomJSimul.Render
{
    using Microsoft.Xna.Framework;
    using SadConsole;

    public class SadConsoleService : IConsoleService
    {
        public void InitializeAndShowMainScreen()
        {
            SadConsole.Game.Create(80, 25);
            SadConsole.Game.OnInitialize = () => SadConsole.Global.CurrentScreen = Initialize();
            SadConsole.Game.Instance.Run();

        }

        private static Console Initialize()
        {
            var console = new Console(80, 25);
            console.FillWithRandomGarbage();
            console.Fill(new Rectangle(3, 3, 23, 3), Color.Violet, Color.Black, 0, 0);
            console.Print(4, 4, "Hello from SadConsole");

            return console;
        }
    }
}
