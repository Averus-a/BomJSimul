﻿namespace BomJSimul.Services
{
    using System;
    using System.Collections.Generic;
    using BomJSimul.Entities;

    /// <summary>
    /// Produce new Item objects.
    /// </summary>
    internal class ItemFactory
    {
        private static readonly Dictionary<string, Item> _itemDictionary = new Dictionary<string, Item>()
        {
            {
                "Лопата",
                new Item()
                {
                    Name = "Лопата",
                    Rarity = Rarity.Rare,
                    DropChance = 30,
                }
            },
            {
                "Удочка",
                new Item()
                {
                    Name = "Удочка",
                    Rarity = Rarity.Rare,
                    DropChance = 30,

                }
            },
            {
                "Бутылка",
                new Item()
                {
                    Name = "Бутылка",
                    Rarity = Rarity.Normal,
                    DropChance = 70,
                }
            },
            {
                "Мелочь",
                new Item()
                {
                    Name = "Мелочь",
                    Count = 100,
                    Rarity = Rarity.Rare,
                    DropChance = 30,
                }
            },
            { 
                "Тулуп",
                new Item()
                {
                    Name = "Тулуп",
                    Rarity = Rarity.VeryRare,
                    DropChance = 30,
                }
            }
        };


        /// <summary>
        /// Создает экземпляр итема.
        /// </summary>
        /// <param name="str">имя итема для которого нужно создать экземпляр.</param>
        /// <returns>экземпляр итема.</returns>
        public static Item Create(string str)
        {
            _itemDictionary.TryGetValue(str, out var item);

            var a = new Item();

            item = a.Clone(item);

            return item;
        }
    }

}
