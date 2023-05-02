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

    [TestMethod]
    public void GetAmount_ReturnAmount_Int()
    {
      //Arrange
      int testAmount = 97;
      Change newChange = new Change(testAmount);
      // Act
      int result = newChange.Cents;
      //Assert
      Assert.AreEqual(testAmount, result);
    }

    [TestMethod]
    public void SetAmount_SetValueOfAmount_Void()
    {
      //Arrange
      Change newChange = new Change(75);
      int newAmount = 75;
      //Act
      newChange.Cents = newAmount;
      //Assert
      Assert.AreEqual(newAmount, newChange.Cents);
    }

    [TestMethod]
    public void CoinCounter_DeterminesAmountOfCoins_Int()
    {
      Change coins = new Change(54);
      int amountOfCoins = coins.CoinCounter();
      Assert.AreEqual(6,amountOfCoins);
    }

    [TestMethod]
    public void PennyCounter_FindPennies_Int()
    {
      Change coins = new Change (4);
      int amountOfCoins = coins.CoinCounter();
      int pennies = coins.GetPC();
      Assert.AreEqual(4,pennies);
    }

    [TestMethod]
    public void DimeCounter_FindPennies_Int()
    {
      Change coins = new Change (4);
      int amountOfCoins = coins.CoinCounter();
      int pennies = coins.GetPC();
      Assert.AreEqual(4,pennies);
    }
  }
}

