using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetNumOfLoaves_ReturnsNumOfLoaves_Int()
    {
      //Arrange
      int numOfLoaves = 4;
      //Act
      Bread newBread = new Bread(numOfLoaves);
      int result = newBread.NumOfLoaves;
      //Assert
      Assert.AreEqual(numOfLoaves, result);
    }

    [TestMethod]
    public void SetNumOfLoaves_SetNumOfLoaves_Int()
    {
      //Arrange
      int numOfLoaves = 4;
      Bread newBread = new Bread(numOfLoaves);
      //Act
      int updatedNumOfLoaves = 6;
      newBread.NumOfLoaves = updatedNumOfLoaves;
      int result = newBread.NumOfLoaves;
      //Assert
      Assert.AreEqual(updatedNumOfLoaves, result);

    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_BreadList()
    {
      List<Bread> newList = new List<Bread> { };
      List<Bread> result = Bread.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public static void ClearAll()
    {
      _loaves.Clear();
    }
    
    [TestMethod]
    public void TotBreadLoavesCost_NumGreaterThanThreeNotDivisibleByThreeCost_30()
    {
      int numOfLoaves = 8;
      Bread testBread = new Bread(numOfLoaves);
      Assert.AreEqual(30, testBread.TotBreadLoavesCost(8));
    }

    [TestMethod]
    public void TotBreadLoavesCost_NumGreaterThanThreeDivisibleByThreeCost_20()
    {
      int numOfLoaves = 6;
      Bread testBread = new Bread(numOfLoaves);
      Assert.AreEqual(20, testBread.TotBreadLoavesCost(6));
    }

    [TestMethod]
    public void TotBreadLoavesCost_ThreeLoavesCost_10()
    {
      int numOfLoaves = 3;
      Bread testBread = new Bread(numOfLoaves);
      Assert.AreEqual(10, testBread.TotBreadLoavesCost(3));
    }

    [TestMethod]
    public void TotBreadLoavesCost_TwoLoavesCost_10()
    {
      int numOfLoaves = 2;
      Bread testBread = new Bread(numOfLoaves);
      Assert.AreEqual(10, testBread.TotBreadLoavesCost(2));
    }

    [TestMethod]
    public void TotBreadLoavesCost_OneLoafCost_Five()
    {
      int numOfLoaves = 1;
      Bread testBread = new Bread(numOfLoaves);
      Assert.AreEqual(5, testBread.TotBreadLoavesCost(1));
    }

    [TestMethod]
    public void TotBreadLoavesCost_ZeroLoavesCost_Zero()
    {
      int numOfLoaves = 0;
      Bread testBread = new Bread(numOfLoaves);
      Assert.AreEqual(0, testBread.TotBreadLoavesCost(0));
    }
  }
}