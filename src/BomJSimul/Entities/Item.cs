namespace BomJSimul.Entities
{
    internal class Item
    {
        public Item()
        {
        }

        public Item(string name, int count, int strength, Rarity rarity, int dropChance)
        {
            Name = name;
            Count = count;
            Strength = strength;
            Rarity = rarity;
            DropChance = dropChance;
        }

        /// <summary>
        /// Имя предмета.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Количество (по умолчанию 1).
        /// </summary>
        public int Count { get; set; } = 1;

        /// <summary>
        /// Прочность.
        /// </summary>
        public int Strength { get; set; }

        /// <summary>
        /// Группы редкости.
        /// </summary>
        public Rarity Rarity { get; set; }

        /// <summary>
        /// Шанс выпадения.
        /// </summary>
        public int DropChance { get; set; }

        /// <summary>
        /// Цена предмета.
        /// </summary>
        public int Cost { get; set; }

        public override string ToString()
        {
            var s = $"{Name} [Количество: {Count}] [{Rarity}]";
            return s;
        }
    }

    internal enum Rarity
    {
        Normal = 4,
        Rare = 3,
        VeryRare = 2,
        Legendary = 1
    }
}
