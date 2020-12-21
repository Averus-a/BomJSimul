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

        public MenuItem(string name, SizeToContent sizeToContent)
            : this(10, 1, sizeToContent)
        {
            Text = Transliteration.From(name);
        }


        public MenuItem(int width, int height)
            : this(width, height, SizeToContent.Fixed)
        {
        }

        public MenuItem(int width, int height, SizeToContent sizeToContent)
            : base(width, height)
        {
            SizeToContent = sizeToContent;

            // Reattach theme
            //Theme.Attached(this);
        }


        public List<MenuItem> ChildItems => _childItems;

        public bool ShowHotkey { get; set; }

        public Microsoft.Xna.Framework.Input.Buttons Hotkey { get; set; }

        public TaskCommand Command { get; set; }

        public SizeToContent SizeToContent { get; } = SizeToContent.Fixed;

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
