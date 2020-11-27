namespace BomJSimul.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;

    internal class MinorStats : INotifyPropertyChanged
    {
        public MinorStats() 
        {
        }

        public MinorStats(string name, int level, Stats major1, Stats major2)
        {
            Name = name;
            Level = level;
            Major1 = major1;
            Major2 = major2;
        }

        public string Name { get; set; } // Имя второстипенного стата

        private int level;

        /// <summary>
        /// Уровень вкачености.
        /// </summary>
        public int Level 
        {
            get { return level; }
            set { level = value; RaisePropertyChanged(nameof(Level)); }
        }

        public Stats Major1 { get; set; }

        public Stats Major2 { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
