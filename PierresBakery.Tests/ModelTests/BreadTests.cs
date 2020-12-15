using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
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
//refactor to PastryTests.cs

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
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
}