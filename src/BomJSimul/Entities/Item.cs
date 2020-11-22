namespace BomJSimul.Entities
{
    internal class Item
    {
        public string Name { get; set; } // Имя предмета

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
