namespace BomJSimul.Entities
{
    internal class Item
    {
        public Item()
        {

        }

        public Item(Item item)
        {
            Name = item.Name;
            Count = item.Count;
            Strength = item.Strength;
            Rarity = item.Rarity;
            DropChance = item.DropChance;
            Cost = item.Count;
        }

        public Item(string name, int count, Rarity rarity, int dropChance, int cost, int strength = 100)
        {
            Name = name;
            Count = count;
            Strength = strength;
            Rarity = rarity;
            DropChance = dropChance;
            Cost = cost;
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

        public Item Clone(Item item)
        {
            return new Item(item);
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
