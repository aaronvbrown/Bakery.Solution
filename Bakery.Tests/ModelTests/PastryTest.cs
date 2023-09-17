using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryOrderConstructor_CreatesInstanceOfPastryOrder_PastryOrder()
    {
      PastryOrder newPastryOrd = new PastryOrder(4);
      Assert.AreEqual(typeof(PastryOrder), newPastryOrd.GetType());
    }

    [TestMethod]
    public void GetAmount_ReturnsAmount_Decimal()
    {
      PastryOrder newPastryOrd = new PastryOrder(10);
      decimal TestAmount = 16;
      Assert.AreEqual(TestAmount, newPastryOrd.GetAmount());
    }
  }
}