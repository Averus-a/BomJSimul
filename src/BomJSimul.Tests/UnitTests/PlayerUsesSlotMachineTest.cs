namespace BomJSimul.UnitTests
{
    using BomJSimul.Entities;
    using BomJSimul.GameLogic;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PlayerUsesSlotMachineTest
    {
        private static readonly Dictionary<string, Player> TestPlayers = new Dictionary<string, Player>()
        {
            {"testPlayer", new Player()},
            {"null", null}
        };


        [Test]
        [TestCase("null", 10, 20, typeof(ArgumentException))]
        [TestCase("testPlayer", 0, 20, typeof(ArgumentException))]
        public void TryingToWinMoneyThrewException(string playerName, int rate, int maximumRate, Type expectedException)
        {
            if (!TestPlayers.TryGetValue(playerName,out var player))
            {
                throw new NotSupportedException();
            }
          
            Exception ex2 = null;

            try
            {
                var slotMashin = new PlayerUsesSlotMachine();
                slotMashin.TryingToWinMoney(player, rate, maximumRate);
            }
            catch (Exception ex)
            {
                ex2 = ex;
            }

            Assert.AreEqual(expectedException, ex2?.GetType());
        }

        //public void TryingToWinMoneyRatesAreValid(Player player, int rate, int maximumRate, Type expectedException)
        // {
        //     Exception ex2 = null;

        // }
    }
}
