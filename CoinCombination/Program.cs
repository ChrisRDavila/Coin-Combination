using System;
using CoinCombination.Models;

namespace CoinCombination
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(@"   _____      _           _____                  _            
  / ____|    (_)         / ____|                | |           
 | |     ___  _ _ __    | |     ___  _   _ _ __ | |_ ___ _ __ 
 | |    / _ \| | '_ \   | |    / _ \| | | | '_ \| __/ _ \ '__|
 | |___| (_) | | | | |  | |___| (_) | |_| | | | | ||  __/ |   
  \_____\___/|_|_| |_|   \_____\___/ \__,_|_| |_|\__\___|_|  ");
      Console.WriteLine("\nPlease enter an amount of change with one unit equaling one penny, under one dollar using 1-99");
      int userInput = int.Parse(Console.ReadLine());
      Change coins = new Change(userInput);
      int amountOfCoins = coins.CoinCounter();
      int quarters = coins.GetQC();
      int dimes = coins.GetDC();
      int nickels = coins.GetNC();
      int pennies = coins.GetPC();
      
      Console.WriteLine($"The total amount of coins is {amountOfCoins}");
      Console.WriteLine($"The amount of quarters is {coins.GetQC()}");
      Console.WriteLine($"The amount of dimes is {coins.GetDC()}");
      Console.WriteLine($"The amount of nickels is {coins.GetNC()}");
      Console.WriteLine($"The amount of pennies is {coins.GetPC()}");
    }
  }
}