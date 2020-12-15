using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetNumOfPastries_ReturnsNumOfPastries_Int()
    {
      //Arrange
      int numOfPastries = 4;
      //Act
      Pastry newPastry = new Pastry(numOfPastries);
      int result = newPastry.NumOfPastries;
      //Assert
      Assert.AreEqual(numOfPastries, result);
    }

    [TestMethod]
    public void SetNumOfPastries_SetNumOfPastries_Int()
    {
      //Arrange
      int numOfPastries = 4;
      Pastry newPastry = new Pastry(numOfPastries);
      //Act
      int updatedNumOfPastries = 6;
      newPastry.NumOfPastries = updatedNumOfPastries;
      int result = newPastry.NumOfPastries;
      //Assert
      Assert.AreEqual(updatedNumOfPastries, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PastryList()
    {
      List<Pastry> newList = new List<Pastry> { };
      List<Pastry> result = Pastry.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      //Arrange
      int pastries01 = 3;
      int pastries02 = 10;
      Pastry newPastry1 = new Pastry(pastries01);
      Pastry newPastry2 = new Pastry(pastries02);
      List<Pastry> newList = new List<Pastry> { newPastry1, newPastry1 };
      //Act
      List<Pastry> result = Pastry.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public static void ClearAll()
    {
      _pastries.Clear();
    }

    [TestMethod]
    public void TotPastryCost_NumberDivisibleByThreeCost_Fifteen()
    {
      int numOfPastries = 9;
      Pastry testPastry = new Pastry(numOfPastries);
      Assert.AreEqual(15, testPastry.TotPastryCost(9));
    }

    [TestMethod]
    public void TotPastryCost_NumberNotDivisibleByThreeCost_Fourteen()
    {
      int numOfPastries = 8;
      Pastry testPastry = new Pastry(numOfPastries);
      Assert.AreEqual(14, testPastry.TotPastryCost(8));
    }

    [TestMethod]
    public void TotPastryCost_NumberNotDivisibleByThreeCost_Seven()
    {
      int numOfPastries = 4;
      Pastry testPastry = new Pastry(numOfPastries);
      Assert.AreEqual(7, testPastry.TotPastryCost(4));
    }
    
    [TestMethod]
    public void TotPastryCost_NumberDivisibleByThreeCost_Five()
    {
      int numOfPastries = 3;
      Pastry testPastry = new Pastry(numOfPastries);
      Assert.AreEqual(5, testPastry.TotPastryCost(3));
    }

    [TestMethod]
    public void TotPastryCost_CostOfOnePastry_Four()
    {
      int numOfPastries = 2;
      Pastry testPastry = new Pastry(numOfPastries);
      Assert.AreEqual(4, testPastry.TotPastryCost(2));
    }

    [TestMethod]
    public void TotPastryCost_CostOfOnePastry_Two()
    {
      int numOfPastries = 1;
      Pastry testPastry = new Pastry(numOfPastries);
      Assert.AreEqual(2, testPastry.TotPastryCost(1));
    }
  }