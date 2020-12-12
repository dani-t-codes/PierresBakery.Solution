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
    public void TotBreadLoaves_NumberDivisibleByThree_20()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(20, testBread.TotBreadLoaves(6));
    }
    [TestMethod]
    public void TotBreadLoaves_NumberNotDivisibleByThree_40()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(40, testBread.TotBreadLoaves(8));
    }
  //   [TestMethod]
  //   public void TotBreadLoaves_TotalReturnsDiscountPriceForLoavesDivisibleByThree_20()
  //   {
  //     Bread testBread = new Bread();
  //     Assert.AreEqual(20, testBread.TotBreadLoaves(6));
  //   }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void TotPastries_NumberDivisibleByThree_True()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(true, testPastry.TotPastries(9));
    }
  }
}
