using System;
using System.Collections.Generic;
using Xunit;

namespace CoinCounterNameSpace
{
  public class CoinCounterTest
  {

      [Fact]
      public void CoinCounter_100cents_4quarters()
      {
         CoinCounter coincounter = new CoinCounter(100);
         Assert.Equal("4 quarter, 0 dime, 0 nickel, 0 penny", coincounter.MakeChange());
         //coincounter.MakeChange()

      }
      [Fact]
      public void CoinCounter_35cents_1quarter1dime()
      {
        CoinCounter coincounter = new CoinCounter(35);
        Assert.Equal("1 quarter, 1 dime, 0 nickel, 0 penny",  coincounter.MakeChange());
      }
      [Fact]
      public void CoinCounter_40cents_1quarter1dime1nickel()
      {
        CoinCounter coincounter = new CoinCounter(40);
        Assert.Equal("1 quarter, 1 dime, 1 nickel, 0 penny",  coincounter.MakeChange());
      }
      [Fact]
      public void CoinCounter_41cents_1quarter1dime1nickel1penny()
      {
        CoinCounter coincounter = new CoinCounter(41);
        Assert.Equal("1 quarter, 1 dime, 1 nickel, 1 penny",  coincounter.MakeChange());
      }
  }
}
