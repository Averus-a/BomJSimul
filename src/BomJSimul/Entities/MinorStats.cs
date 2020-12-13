namespace BomJSimul.Entities
{
    using System.ComponentModel;

    internal class MinorStats : INotifyPropertyChanged
    {
        private int level;

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

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; } // Имя второстипенного стата

        /// <summary>
        /// Уровень вкачености.
        /// </summary>
        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
                RaisePropertyChanged(nameof(Level));
            }
        }

        public Stats Major1 { get; set; }

        public Stats Major2 { get; set; }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
