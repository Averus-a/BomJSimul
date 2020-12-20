namespace BomJSimul.Gui.Sad
{
    using System.Collections.Generic;
    using System.Linq;
    using BomJSimul.Text;
    using Catel.MVVM;
    using SadConsole.Controls;

    public class MenuItem : ButtonBase
    {
        private readonly List<MenuItem> _childItems = new List<MenuItem>();

        public MenuItem(string name)
            : this(10, 1)
        {
            Text = Transliteration.From(name);
        }

        public MenuItem(int width, int height)
            : base(width, height)
        {
        }

        public List<MenuItem> ChildItems => _childItems;

        public bool ShowHotkey { get; set; }

        public Microsoft.Xna.Framework.Input.Buttons Hotkey { get; set; }

        public TaskCommand Command { get; set; }

        public override void DoClick()
        {
            if (ChildItems.Any())
            {
                ShowSubMenu();
            }
            else
            {
                ExecuteCommand();
            }
        }

        private void ShowSubMenu()
        {

        }

        private void ExecuteCommand()
        {

        }
    }
}
