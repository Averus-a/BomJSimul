namespace BomJSimul.UnitTests
{
    using BomJSimul.Entities;
    using BomJSimul.GameLogic;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class PlayerUsesSlotMachineTest
    {
        [Test]
        [TestCase(null, 10, 20, typeof(ArgumentException))]
        internal void TryingToWinMoney(Player player, int rate, int maximumRate, Type expectedException)
        {
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

            Assert.AreEqual(ex2?.GetType(), expectedException);
        }
    }
}
