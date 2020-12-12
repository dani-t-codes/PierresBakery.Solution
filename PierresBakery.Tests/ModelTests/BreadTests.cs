using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
using PierresBakery;
// using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void TotBreadLoaves_NumGreaterThanThreeNotDivisibleByThreeCost_30()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(30, testBread.TotBreadLoaves(8));
    }

    [TestMethod]
    public void TotBreadLoaves_NumGreaterThanThreeDivisibleByThreeCost_20()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(20, testBread.TotBreadLoaves(6));
    }

    [TestMethod]
    public void TotBreadLoaves_ThreeLoavesCost_10()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.TotBreadLoaves(3));
    }

    [TestMethod]
    public void TotBreadLoaves_TwoLoavesCost_10()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.TotBreadLoaves(2));
    }

    [TestMethod]
    public void TotBreadLoaves_OneLoafCost_Five()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(5, testBread.TotBreadLoaves(1));
    }

    [TestMethod]
    public void TotBreadLoaves_ZeroLoavesCost_Zero()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(0, testBread.TotBreadLoaves(0));
    }

  // [TestClass]
  // public class PastryTests
  // {
  //   [TestMethod]
  //   public void TotPastries_NumberDivisibleByThree_True()
  //   {
  //     Pastry testPastry = new Pastry();
  //     Assert.AreEqual(true, testPastry.TotPastries(9));
  //   }
  // [TestMethod]
  //   public void TotPastries_NumberNotDivisibleByThree_False()
  //   {
  //     Pastry testPastry = new Pastry();
  //     Assert.AreEqual(false, testPastry.TotPastries(7));
  //   }
  }
}