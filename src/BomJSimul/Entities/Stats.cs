namespace BomJSimul.Entities
{
    internal class Stats
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

        public int Level { get; private set; } // Уровень вкачености


        public int Update(int value)
        {
            return Level += value;
        }

    }
}
