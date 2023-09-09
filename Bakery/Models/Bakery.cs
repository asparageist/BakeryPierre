using System.Collections.Generic;
using System;

namespace Pierre.Models
{
  public class BakeryOrder
  {
    public static int BreadPrice(int input)
    {
      int freeBread = (input / 3);
      int totalBreadCost = (input * 5) - (freeBread * 5);
      return totalBreadCost;
    }

    public static int PastryPrice(int input)
    {
      return input * 3;
    }
  }
}