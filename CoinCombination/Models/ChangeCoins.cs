namespace CoinCombination.Models
{
  public class Change
  {
    // Business Logic goes here.
    
    public int Cents{get;set;}

    public Change(int money)
    {
      Cents = money;
    }
  }
}

/*

no need to work with numbers over 100 or under 0

loop this{

if   > 25 -> -25 +1 quarter counter 
else if > 10 -> -10 +1 dime counter
else if > 5 -> -5 +1 nickle counter
else -1 +1  penny counter

}
*/