using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public Pastry()
    {
      Price = 2;
    }
    public int PastryPrice(int pieces)
    {
      int freePastry = (pieces / 4);
      int totalPastryCost = (pieces * Price) - (freePastry * Price);
      return totalPastryCost;
    }
  }
}