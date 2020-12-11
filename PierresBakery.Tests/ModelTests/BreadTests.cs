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
    public void TotBreadLoaves_NumberDivisibleByThree_True()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(true, testBread.TotBreadLoaves(6));
    }
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
