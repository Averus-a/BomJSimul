namespace BomJSimul.Gui.Sad
{
    using Microsoft.Xna.Framework;
    using SadConsole;
    using System.Collections.ObjectModel;
    using System.Text;

    internal class FooterMenuView : Console
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

            DrawMenu();
        }

        public ObservableCollection<MenuItem> Items => _menuItems;

        public void Add(MenuItem menuItem)
        {
            Items.Add(menuItem);
        }

        public void DrawMenu()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < _menuItems.Count; i++)
            {
                sb.Append(_menuItems[i].Name);
                sb.Append("   |"); // 3 spaces + delimiter
            }

            Print(1, 0, sb.ToString());
        }
    }
}
