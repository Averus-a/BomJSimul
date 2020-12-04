namespace BomJSimul.Gui.Sad
{
    using System.Collections.Generic;
    using BomJSimul.Text;

    public class MenuItem
    {
        private readonly List<MenuItem> _childItems = new List<MenuItem>();

        public MenuItem(string name)
        {
            Name = name;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            { 
                _name = Transliteration.From(value); 
            }
        }


        public List<MenuItem> ChildItems => _childItems;
    }
}
