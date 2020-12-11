using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bread;
using Models;

namespace Bread.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void TotBreadLoaves_NumberDivisibleByThree_True()
    {
      TotBreadLoaves testBreadLoaves = new TotBreadLoaves();
      Assert.AreEqual(true, testTotBreadLoaves.TotBreadLoaves(6));
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
