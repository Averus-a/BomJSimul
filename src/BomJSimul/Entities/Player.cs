namespace BomJSimul.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Player
    {
        private readonly List<MinorStats> _minorStats = new List<MinorStats>();

        public Player()
        {
            _minorStats = new List<MinorStats>()
            {
                new MinorStats()
                {
                    Name = "Второстепенный стат 0",
                    Major1 = Fearlessness,
                    Major2 = Fearlessness,
                },
                new MinorStats()
                {
                    Name = "Второстепенный стат 1",
                },

                new MinorStats()
                {
                    Name = "Второстепенный стат 2",
                },

                new MinorStats()
                {
                    Name = "Второстепенный стат 3",
                },

                new MinorStats()
                {
                    Name = "Второстепенный стат 4",
                },

                new MinorStats()
                {
                    Name = "Второстепенный стат 5",
                },

                new MinorStats()
                {
                    Name = "Второстепенный стат 6",
                },

                new MinorStats()
                {
                    Name = "Второстепенный стат 7",
                },

                new MinorStats()
                {
                    Name = "Второстепенный стат 8",
                },

                new MinorStats()
                {
                    Name = "Второстепенный стат 9",
                },

                new MinorStats()
                {
                    Name = "Второстепенный стат 10",
                },

                new MinorStats()
                {
                    Name = "Второстепенный стат 11",
                },
            };
        }

        public string Name { get; set; } // Имя Персонажа (НУЖНО ПРИДЕЛАТЬ СКЛОНЕНИЯ)

        public int Age { get; set; } // возраст

        public int Money { get; set; } // Money деньги

        // ++++++++++++++++++++++++++++++++Первостепенное+++++++++++++++++++++++++++++++++

        /// <summary>
        /// Бесстрашие.
        /// </summary>
        public Stats Fearlessness { get; set; } = new Stats();

        /// <summary>
        /// Обаяние.
        /// </summary>
        public Stats Charm { get; set; } = new Stats();

        /// <summary>
        /// Мудрость.
        /// </summary>
        public Stats Wisdom { get; set; } = new Stats();

        /// <summary>
        /// Жизнь.
        /// </summary>
        public Stats Life { get; set; } = new Stats();

        /// <summary>
        /// Удача.
        /// </summary>
        public Stats Luck { get; set; } = new Stats();

    }
}
