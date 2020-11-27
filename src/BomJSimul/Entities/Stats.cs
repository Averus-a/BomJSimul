namespace BomJSimul.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Stats
    {
        public Stats()
        {
        }

        public Stats(string name, int level)
        {
            Name = name;
            Level = level;
        }



        public string Name { get; set; } // Имя стата

        public int Level { get; set; } // Уровень вкачености

    }
}
