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
  public class Pastry_Tests
  {
    [TestMethod]
    public void PastryCost_NumberDivisibleByThree_True()
    {
      //testing code here
    }
  }
}
