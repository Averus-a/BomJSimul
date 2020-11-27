namespace BomJSimul.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Player
    {

        public Player()
        {
            MinorStats = new List<MinorStats>()
            {
                new MinorStats()
                {
                    Name = "Второстипенный стат 0",
                    Major1 = Fearlessness,
                    Major2 = Fearlessness,
                },
                new MinorStats()
                {
                    Name = "Второстипенный стат 1",
                },

                new MinorStats()
                {
                    Name = "Второстипенный стат 2",
                },

                new MinorStats()
                {
                    Name = "Второстипенный стат 3",
                },

                new MinorStats()
                {
                    Name = "Второстипенный стат 4",
                },

                new MinorStats()
                {
                    Name = "Второстипенный стат 5",
                },

                new MinorStats()
                {
                    Name = "Второстипенный стат 6",
                },

                new MinorStats()
                {
                    Name = "Второстипенный стат 7",
                },

                new MinorStats()
                {
                    Name = "Второстипенный стат 8",
                },

                new MinorStats()
                {
                    Name = "Второстипенный стат 9",
                },

                new MinorStats()
                {
                    Name = "Второстипенный стат 10",
                },

                new MinorStats()
                {
                    Name = "Второстипенный стат 11",
                },
            };
        }

        public string Name { get; set; } // Имя Персонажа (НУЖНО ПРИДЕЛАТЬ СКЛОНЕНИЯ)

        public int Age { get; set; } // возраст

        public int Money { get; set; } // Money деньги

        // ++++++++++++++++++++++++++++++++Первостепенное+++++++++++++++++++++++++++++++++

        public Stats Fearlessness { get; set; } // Б - Бесстрашие

        public Stats Charm { get; set; } // О - Обаяние

        public Stats Wisdom { get; set; } // М - Мудрость

        public Stats LifeForce { get; set; } // Ж - Жизненная сила

        public Stats Luck { get; set; } // Удача

        // ++++++++++++++++++++++++++++++++Второстипенное+++++++++++++++++++++++++++++++++

        public List<MinorStats> MinorStats = new List<MinorStats>()
        {

        };

        private static int BasicStatCalculation(int a, int b)
        {
            return a = a + b;
        }

    }
}
