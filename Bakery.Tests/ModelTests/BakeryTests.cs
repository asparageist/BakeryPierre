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
      //Arrange
      BakeryOrder order = new BakeryOrder();
      //Act
      int breadNumber = 3;
      int breadCost = BakeryOrder.BreadPrice(breadNumber);
      //Assert
      Assert.AreEqual(breadCost, 15);
    }
    [TestMethod]
    public void BakeryOrder_CalculatePastry()
    {
      //Arrange
      BakeryOrder order = new BakeryOrder();
      //Act
      int pastryNumber = 3;
      int pastryCost = BakeryOrder.PastryPrice(pastryNumber);
      //Assert
      Assert.AreEqual(pastryCost, 9);
    }
    [TestMethod]
    public void BakeryOrder_BreadDiscount()
    {
      //Arrange
      BakeryOrder order = new BakeryOrder();
      //Act
      int breadNumber = 6;
      int breadCost = BakeryOrder.BreadPrice(breadNumber);
      //Assert
      Assert.AreEqual(breadCost, 20);
    }


  }
}