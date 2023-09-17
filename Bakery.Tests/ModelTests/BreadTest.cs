using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadOrderConstructor_CreatesInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrd = new BreadOrder(4);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrd.GetType());
    }
  }
  // [TestMethod]
  // public void GetAmount_ReturnsAmount_Decimal()
  // {
  //   BreadOrder newBreadOrder = new BreadOrder(4);
  //   Assert.AreEqual(typeof(decimal), newBreadOrder.GetAmount());
  // }
}