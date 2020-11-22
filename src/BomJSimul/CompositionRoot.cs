namespace BomJSimul
{
    using BomJSimul.Render;
    using Catel.IoC;

    internal static class CompositionRoot
    {
        public static void Initialize()
        {
            var serivceLocator = ServiceLocator.Default;
            //serivceLocator.RegisterType<IConsoleService, GuiCsService>();
            serivceLocator.RegisterType<IConsoleService, SadConsoleService>();
        }
    }
}
