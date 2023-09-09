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
      int breadNumber = 2;
      int breadCost = BakeryOrder.BreadPrice(breadNumber);
      //Assert
      Assert.AreEqual(breadCost, 10);
    }
    [TestMethod]
    public void BakeryOrder_CalculatePastry()
    {
      //Arrange
      BakeryOrder order = new BakeryOrder();
      //Act
      int pastryNumber = 2;
      int pastryCost = BakeryOrder.PastryPrice(pastryNumber);
      //Assert
      Assert.AreEqual(pastryCost, 6);
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
    [TestMethod]
    public void BakeryOrder_PastryDiscount()
    {
      //Arrange
      BakeryOrder order = new BakeryOrder();
      //Act
      int pastryNumber = 8;
      int pastryCost = BakeryOrder.PastryPrice(pastryNumber);
      //Assert
      Assert.AreEqual(pastryCost, 9);
    }


  }
}