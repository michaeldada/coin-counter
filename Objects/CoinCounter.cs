using System;
using System.Linq;
using System.Collections.Generic;

namespace CoinCounterNameSpace
{
  public class CoinCounter
  {
    private int _cents;


    public CoinCounter(int cents)
    {
      _cents = cents;
    }

    public int GetCents()
    {
      return _cents;
    }

    public string MakeChange()
    {
        int inputtedCents  = _cents;
        int quarteredCents = inputtedCents / 25;

        int quarteredRemainder = inputtedCents % 25;
        int tenedCents = quarteredRemainder/10;

        int dimedRemainder = quarteredRemainder % 10;
        int nickeledCents = dimedRemainder/5;

        int nickeledRemainder = dimedRemainder % 5;
        int penniedCents = nickeledRemainder/1;







        return quarteredCents  + " quarter, " + tenedCents + " dime, " + nickeledCents + " nickel, " + penniedCents + " penny";


    }
  }
}
