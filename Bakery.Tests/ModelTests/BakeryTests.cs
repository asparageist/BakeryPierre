using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BakeryOrder_CalculateBread()
    {
      int breadNumber = 2;
      int breadCost = BakeryOrder.BreadPrice(breadNumber);

      Assert.AreEqual(breadCost, 10);
    }
    [TestMethod]
    public void BakeryOrder_CalculatePastry()
    {
      int pastryNumber = 2;
      int pastryCost = BakeryOrder.PastryPrice(pastryNumber);

      Assert.AreEqual(pastryCost, 4);
    }
    [TestMethod]
    public void BakeryOrder_BreadDiscount()
    {
      int breadNumber = 6;
      int breadCost = BakeryOrder.BreadPrice(breadNumber);

      Assert.AreEqual(breadCost, 20);
    }
    [TestMethod]
    public void BakeryOrder_PastryDiscount()
    {
      int pastryNumber = 8;
      int pastryCost = BakeryOrder.PastryPrice(pastryNumber);

      Assert.AreEqual(pastryCost, 12);
    }
    [TestMethod]
    public void BakeryOrder_BreadAndPastryCost()
    {
      int breadNumber = 6;
      int pastryNumber = 8;
      int totalCost = BakeryOrder.TotalPrice(breadNumber, pastryNumber);

      Assert.AreEqual(totalCost, 32);
    }
  }
}