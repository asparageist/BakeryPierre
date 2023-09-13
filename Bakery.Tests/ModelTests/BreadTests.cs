using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_ConstructorCreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(newBread.GetType(), typeof(Bread));
    }

    [TestMethod]
    public void Bread_ConstructorCreatesInstanceOfBreadWithPriceEqualToFive_Int()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(newBread.Price, 5);
    }

    [TestMethod]
    public void Bread_PriceSetterProperlySetsPriceProperty_Int()
    {
      Bread newBread = new Bread();
      newBread.Price = 10;
      Assert.AreEqual(newBread.Price, 10);
    }

    [TestMethod]
    public void Bread_CalculateBread_Int()
    {
      Bread newBread = new Bread();
      int breadNumber = 2;
      int breadCost = newBread.BreadPrice(breadNumber);

      Assert.AreEqual(breadCost, 10);
    }

    [TestMethod]
    public void Bread_BreadPriceProperlyCalculatesDiscount_Int()
    {
      Bread newBread = new Bread();
      int breadNumber = 6;
      int breadCost = newBread.BreadPrice(breadNumber);

      Assert.AreEqual(breadCost, 20);
    }
  }
}