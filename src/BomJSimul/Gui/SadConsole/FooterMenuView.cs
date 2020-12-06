namespace BomJSimul.Gui.Sad
{
    using System.Collections.ObjectModel;
    using Microsoft.Xna.Framework;
    using SadConsole;

    internal class FooterMenuView : ControlsConsole
    {
        private readonly ObservableCollection<MenuItem> _menuItems;
        public FooterMenuView(Console mainConsole, int height)
                : base(mainConsole.Width, height)
        {
            this.Parent = mainConsole;

            var backgroundColor = Color.DarkGray;
            var foregroundColor = Color.White;

            this.Fill(foregroundColor, backgroundColor, 0);

            _menuItems = new ObservableCollection<MenuItem>();
        }

        public ObservableCollection<MenuItem> Items => _menuItems;

        public void AddMenu(MenuItem menuItem)
        {
            Items.Add(menuItem);
        }

        public void AttachMenu()
        {
            for (int i = 0; i < _menuItems.Count; i++)
            {
                var currentMenu = _menuItems[i];

                if (i > 0)
                {
                    var previousMenu = _menuItems[i - 1];
                    currentMenu.Position = new Point(previousMenu.Position.X + previousMenu.Width + 1, 0);
                }

                Add(currentMenu);
            }
        }
    }
}
