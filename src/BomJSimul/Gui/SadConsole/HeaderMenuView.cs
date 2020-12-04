namespace BomJSimul.Gui.Sad
{
    using System.Collections.ObjectModel;
    using System.Text;
    using Microsoft.Xna.Framework;
    using SadConsole;

    internal class HeaderMenuView : Console
    {
        private readonly ObservableCollection<MenuItem> _menuItems;

        public HeaderMenuView(Console mainConsole, int height)
              : base(mainConsole.Width, height)
        {
            this.Parent = mainConsole;

            this.Fill(Color.White, Color.DarkGray, 0);

            _menuItems = new ObservableCollection<MenuItem>();

            DrawMenu();
        }

        public ObservableCollection<MenuItem> Items => _menuItems;

        public void Add(MenuItem menuItem)
        {
            Items.Add(menuItem);
        }

        /// <summary>
        /// Draws menu items.
        /// </summary>
        public void DrawMenu()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < _menuItems.Count; i++)
            {
                sb.Append(_menuItems[i].Name);
                sb.Append("     "); // 5 spaces
            }

            Print(1, 0, sb.ToString());
        }
    }
}
