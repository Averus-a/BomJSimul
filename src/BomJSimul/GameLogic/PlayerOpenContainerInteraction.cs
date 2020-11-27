namespace BomJSimul.GameLogic
{
    using System;
    using System.Collections.Generic;
    using BomJSimul.Engine;
    using BomJSimul.Entities;
    using Weighted_Randomizer;

    internal class PlayerOpenContainerInteraction : BomJSimul.Engine.SceneEvent
    {
        public SceneObject TrashBin { get; set; }

        public bool HaveYouUsed { get; set; }

        private DateTime _lastTimeOpened;

        private readonly List<Item> _containerObjects = new List<Item>()
        {
            new Item()
            {
                Name = "Лопата",
                Strength = Randomness(1,100),
                Rarity = Rarity.Rare,
                DropChance = 30,
            },

            new Item()
            {
                Name = "Удочка",
                Strength = Randomness(1,100),
                Rarity = Rarity.Rare,
                DropChance = 30,

            },

            new Item()
            {
                Name = "Бутылка",
                Strength = Randomness(1,100),
                Rarity = Rarity.Normal,
                DropChance = 70,
            },

            new Item()
            {
                Name = "Мелочь",
                Count = Randomness(10,100),
                Strength = Randomness(1,100),
                Rarity = Rarity.Rare,
                DropChance = 30,
            },

            new Item()
            {
                Name = "Тулуп",
                Strength = Randomness(1,100),
                Rarity = Rarity.VeryRare,
                DropChance = 30,
            },
        };

        public void Open()
        {
            if (_lastTimeOpened.DayOfYear < DateTime.UtcNow.DayOfYear)
            {
                HaveYouUsed = false;
            }

            if (!HaveYouUsed)
            {
                HaveYouUsed = true;
                _lastTimeOpened = DateTime.UtcNow;

                return;
            }

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

        private IWeightedRandomizer<Item> _randomizer = new StaticWeightedRandomizer<Item>();
        
        private Item GetRandomItem()
        {
            // тип инт или итем? или поставить вар?
            foreach (var i in _containerObjects)
            {
                _randomizer.Add(i, i.DropChance);
            }

            var randomItem = _randomizer.NextWithReplacement();

            return randomItem;
        }
    }
}
