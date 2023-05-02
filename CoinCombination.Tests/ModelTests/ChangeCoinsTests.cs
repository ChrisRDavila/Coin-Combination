using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCombination.Models;


namespace CoinCombination.Tests
{
  [TestClass]
  public class ChangeCounterTests 
  {
    [TestMethod]
    public void ChangeConstuctor_CreateInstancesofCoins_Coins() 
    {
      Change newChange = new Change(97);
      Assert.AreEqual(typeof(Change), newChange.GetType()); 
    }
  }
}

