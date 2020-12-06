namespace BomJSimul.GameLogic
{
    using BomJSimul.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Просить милостыню (+рандомно денег).
    /// </summary>
    class BegForMoney
    {
        /// <summary>
        /// реплика дающего.
        /// </summary>
        private readonly List<string> _speechOfTheGiver = new List<string>();

        private static readonly Random _random = new Random();

        public BegForMoney()
        {
            _speechOfTheGiver.Add("Первый диалог");
            _speechOfTheGiver.Add("Второй диалог");
            _speechOfTheGiver.Add("Третий диалог");
        }

        /// <summary>
        /// Присваевает N количество денег и говорит рандомный диалог.
        /// </summary>
        /// <param name="player">Текущий игрок.</param>
        /// <param name="maxMoney">Максимальное возможное.</param>
        public void GiveMeMoney(Player player, int maxMoney)
        {
            int speechCount = _speechOfTheGiver.Count;
            int speechRandom = _random.Next(0, speechCount);
            int randomMoney = _random.Next(0, maxMoney + 1);

            Console.WriteLine($"{_speechOfTheGiver[speechRandom]} И дал денег: {randomMoney} едениц");

            player.Money += randomMoney;
        }
    }
}
