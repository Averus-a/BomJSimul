namespace BomJSimul.GameLogic
{
    using System;
    using BomJSimul.Entities;

    public class PlayerUsesSlotMachine
    {
        /// <summary>
        /// слотмашина.
        /// </summary>
        /// <param name="player">Текущий игрок.</param>
        /// <param name="rate">Cтавка.</param>
        /// <param name="maximumRate">Максимальный выигрыш (прибыль).</param>
        /// <returns>возвращает рандомное число если денег больше чем ставка.</returns>
        public int? TryingToWinMoney(Player player, int rate, int maximumRate)
        {
            if (player.Money >= rate)
            {
                player.Money -= rate;

                var result = new Random().Next(0, maximumRate + 1);

                if (result == 0)
                {
                    player.Luck.Update(-1);

                    Console.WriteLine("Лузер Лузер!");
                }

                if (result == maximumRate)
                {
                    player.Luck.Update(1);

                    Console.WriteLine("А ты фартовый!");
                }

                return result;
            }

            return null;
        }
    }
}