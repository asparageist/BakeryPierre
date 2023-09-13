using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_ConstructorCreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(newPastry.GetType(), typeof(Pastry));
    }
    [TestMethod]
    public void Pastry_ConstructorCreatesInstanceOfPastryWithPriceEqualToTwo_Int()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(newPastry.Price, 2);
    }

    [TestMethod]
    public void Pastry_PriceSetterProperlySetsPriceProperty_Int()
    {
      Pastry newPastry = new Pastry();
      newPastry.Price = 10;
      Assert.AreEqual(newPastry.Price, 10);
    }

    [TestMethod]
    public void Pastry_CalculatePastry_Int()
    {
      Pastry newPastry = new Pastry();
      int pastryNumber = 2;
      int pastryCost = newPastry.PastryPrice(pastryNumber);

      Assert.AreEqual(pastryCost, 4);
    }

    [TestMethod]
    public void Pastry_PastryPriceProperlyCalculatesDiscount_Int()
    {
      Pastry newPastry = new Pastry();
      int pastryNumber = 8;
      int pastryCost = newPastry.PastryPrice(pastryNumber);

      Assert.AreEqual(pastryCost, 12);
    }

  }
}