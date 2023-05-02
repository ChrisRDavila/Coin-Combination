namespace CoinCombination.Models
{
  public class Change
  {
    // Business Logic goes here.
    
    public int Cents{get;set;}
    private int _qC;
    private int _dC;
    private int _nC;
    private int _pC;

    public Change(int money)
    {
      Cents = money;
    }
    
    public int GetQC()
    {
      return _qC;
    }
    public int GetDC()
    {
      return _dC;
    }
    public int GetNC()
    {
      return _nC;
    }
    public int GetPC()
    {
      return _pC;
    }

    public int CoinCounter()
    {
      int quarterCounter = 0;
      int dimeCounter = 0;
      int nickleCounter = 0;
      int pennyCounter = 0;
      int money = Cents;
      while(money > 0)
      {
        if(money >=25)
        {
          money -= 25;
          quarterCounter++;
        } else if (money >= 10)
        {
          money -= 10;
          dimeCounter++;
        } else if (money >= 5)
        {
          money -= 5;
          nickleCounter++;
        } else 
        {
          money -=1;
          pennyCounter++;
        }
      }
      _pC = pennyCounter;
      _dC = dimeCounter;
      _nC = nickleCounter;
      _qC = quarterCounter;
      return quarterCounter + dimeCounter + nickleCounter + pennyCounter;
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