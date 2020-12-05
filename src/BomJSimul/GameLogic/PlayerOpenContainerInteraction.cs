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
        private static readonly Random _random = new Random();

        private readonly List<Item> _containerObjects = new List<Item>()
        {
            new Item()
            {
                Name = "Лопата",
                Strength = _random.Next(1, 100),
                Rarity = Rarity.Rare,
                DropChance = 30,
            },

            new Item()
            {
                Name = "Удочка",
                Strength = _random.Next(1, 100),
                Rarity = Rarity.Rare,
                DropChance = 30,

            },

            new Item()
            {
                Name = "Бутылка",
                Strength = _random.Next(1, 100),
                Rarity = Rarity.Normal,
                DropChance = 70,
            },

            new Item()
            {
                Name = "Мелочь",
                Count = _random.Next(10, 100),
                Strength = _random.Next(1, 100),
                Rarity = Rarity.Rare,
                DropChance = 30,
            },

            new Item()
            {
                Name = "Тулуп",
                Strength = _random.Next(1, 100),
                Rarity = Rarity.VeryRare,
                DropChance = 30,
            },
        };
        private readonly IWeightedRandomizer<Rarity> _randomizerRarity = new StaticWeightedRandomizer<Rarity>();

        private DateTime _lastTimeOpened; 

        public PlayerOpenContainerInteraction()
        {
            var rarities = Enum.GetValues(typeof(Rarity));

            foreach (Rarity i in rarities)
            {
                _randomizerRarity.Add(i, (int)i);
            }
        }
        
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

        /// <summary>
        /// Return random item picked from drop-list with chose rarity.
        /// </summary>
        /// <returns>
        /// Item.
        /// </returns>
        public Item GetRandomItem()
        {
            var randomRarity = _randomizerRarity.NextWithReplacement();

            var randomizerDropChance = new StaticWeightedRandomizer<Item>();

            foreach (var i in _containerObjects.Where(item => item.Rarity == randomRarity))
            {
                randomizerDropChance.Add(i, i.DropChance);
            }

            if (!randomizerDropChance.Any())
            {
                return GetRandomItem();
            }

            var randomItem = randomizerDropChance.NextWithReplacement();

            return randomItem;
        }
    }
}
