using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public Bread()
    {
      Price = 5;
    }
    public int BreadPrice(int loaves)
    {
      int freeBread = (loaves / 3);
      int totalBreadCost = (loaves * Price) - (freeBread * Price);
      return totalBreadCost;
    }
  }
}