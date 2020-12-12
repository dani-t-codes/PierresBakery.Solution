using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void TotBreadLoavesCost_NumGreaterThanThreeNotDivisibleByThreeCost_30()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(30, testBread.TotBreadLoavesCost(8));
    }

    [TestMethod]
    public void TotBreadLoavesCost_NumGreaterThanThreeDivisibleByThreeCost_20()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(20, testBread.TotBreadLoavesCost(6));
    }

    [TestMethod]
    public void TotBreadLoavesCost_ThreeLoavesCost_10()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.TotBreadLoavesCost(3));
    }

    [TestMethod]
    public void TotBreadLoavesCost_TwoLoavesCost_10()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.TotBreadLoavesCost(2));
    }

    [TestMethod]
    public void TotBreadLoavesCost_OneLoafCost_Five()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(5, testBread.TotBreadLoavesCost(1));
    }

    [TestMethod]
    public void TotBreadLoavesCost_ZeroLoavesCost_Zero()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(0, testBread.TotBreadLoavesCost(0));
    }
  }
//refactor to PastryTests.cs

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void TotPastryCost_NumberDivisibleByThreeCost_Fifteen()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(15, testPastry.TotPastryCost(9));
    }

    [TestMethod]
    public void TotPastryCost_NumberNotDivisibleByThreeCost_Fourteen()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(14, testPastry.TotPastryCost(8));
    }

  [TestMethod]
    public void TotPastryCost_NumberNotDivisibleByThreeCost_Seven()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(7, testPastry.TotPastryCost(4));
    }
    
    [TestMethod]
    public void TotPastryCost_NumberDivisibleByThreeCost_Five()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(5, testPastry.TotPastryCost(3));
    }

    [TestMethod]
    public void TotPastryCost_CostOfOnePastry_Four()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(4, testPastry.TotPastryCost(2));
    }

      [TestMethod]
    public void TotPastryCost_CostOfOnePastry_Two()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(2, testPastry.TotPastryCost(1));
    }
  }
}