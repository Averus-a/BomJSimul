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


        public string Name { get; set; } // Имя предмета

        public int Count { get; set; } = 1; // Количество (по умолчанию 1)

        public int Strength { get; set; } // Прочность

        public Rarity Rarity { get; set; } // Групы редкости

        public int DropChance { get; set; }// Шанс выпадения

        public override string ToString()
        {
            var s = $"{Name} [Количество: {Count}] [{Rarity}]";
            return s;
        }
        // Имя_предмета [Количество: XX] [Класс_редкости]
    }

    internal enum Rarity
    {
        Normal = 4,
        Rare = 3,
        VeryRare = 2,
        Legendary = 1
    }
}
