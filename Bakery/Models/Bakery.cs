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
      int freePastry = (input / 4);
      int totalPastryCost = (input * 3) - (freePastry * 3);
      return totalPastryCost;
    }

    public static int TotalPrice(int inputB, int inputP)
    {
      int breadCost = BreadPrice(inputB);
      int pastryCost = PastryPrice(inputP);
      int totalCost = breadCost + pastryCost;
      return totalCost;
    }
  }
}