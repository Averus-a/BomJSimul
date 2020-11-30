namespace BomJSimul.GameLogic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BomJSimul.Engine;
    using BomJSimul.Entities;
    using Weighted_Randomizer;

    internal class PlayerOpenContainerInteraction : BomJSimul.Engine.SceneEvent
    {
        private readonly List<Item> _containerObjects = new List<Item>()
        {
            new Item()
            {
                Name = "Лопата",
                Strength = Randomness(1, 100),
                Rarity = Rarity.Rare,
                DropChance = 30,
            },

            new Item()
            {
                Name = "Удочка",
                Strength = Randomness(1, 100),
                Rarity = Rarity.Rare,
                DropChance = 30,

            },

            new Item()
            {
                Name = "Бутылка",
                Strength = Randomness(1, 100),
                Rarity = Rarity.Normal,
                DropChance = 70,
            },

            new Item()
            {
                Name = "Мелочь",
                Count = Randomness(10, 100),
                Strength = Randomness(1, 100),
                Rarity = Rarity.Rare,
                DropChance = 30,
            },

            new Item()
            {
                Name = "Тулуп",
                Strength = Randomness(1, 100),
                Rarity = Rarity.VeryRare,
                DropChance = 30,
            },
        };
        
        private DateTime _lastTimeOpened; 
        
        public SceneObject TrashBin { get; set; }

        public bool HaveYouUsed { get; set; }

        public Item Open()
        {
            if (_lastTimeOpened.DayOfYear < DateTime.UtcNow.DayOfYear)
            {
                HaveYouUsed = false;
                return null;
            }

            if (!HaveYouUsed)
            {
                HaveYouUsed = true;
                _lastTimeOpened = DateTime.UtcNow;

                return GetRandomItem();
            }
            return null;
        }

        private static int Randomness(int min, int max)
        {
            // Создание объекта для генерации чисел
            Random rnd = new Random();

            // Получить очередное (в данном случае - первое) случайное число
            int value = rnd.Next(min, max);

            // Вернуть полученное значение
            return value;
        }

        private IWeightedRandomizer<Item> _randomizerDropChance = new StaticWeightedRandomizer<Item>();
        private IWeightedRandomizer<Rarity> _randomizerRarity = new StaticWeightedRandomizer<Rarity>();

        /// <summary>
        /// Return random item picked from drop-list with chose rarity.
        /// </summary>
        /// <returns>
        /// Item.
        /// </returns>
        public Item GetRandomItem()
        {
            foreach (Rarity i in Enum.GetValues(typeof(Rarity)))
            {
                _randomizerRarity?.Add(i, (int)i);
            }

            var randomRarity = _randomizerRarity.NextWithReplacement();

            foreach (var i in _containerObjects.Where(item => item.Rarity == randomRarity))
            {
                _randomizerDropChance.Add(i, i.DropChance);
            }

            if (!_randomizerDropChance.Any())
            {
                return GetRandomItem();
            }

            var randomItem = _randomizerDropChance.NextWithReplacement();

            return randomItem;
        }
    }
}
