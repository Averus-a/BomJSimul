namespace BomJSimul.Entities
{
    internal class Item
    {
        public Item()
        {
        }

        public Item(string name, int count, int strength, Rarity rarity, double dropChance) 
        {
            Name = name;
            Count = count;
            Strength = strength;
            Rarity = rarity;
            DropChance = dropChance;
        }


        public string Name { get; set; } // Имя предмета

        public int Count { get; set; } // Количество

        public int Strength { get; set; } // Прочность

        public Rarity Rarity { get; set; } // Групы редкости

        public double DropChance { get; set; }// Шанс выпадения

    }

    internal enum Rarity
    {
        Normal = 0,
        Rare = 1,
        VeryRare = 2,
        Legendary = 3
    }
}
