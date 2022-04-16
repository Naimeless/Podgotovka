using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using System;

namespace UnitTest
{
    [TestClass]
    public class SquareUnitTest
    {
        [TestMethod]
        public void SquareTestMethod()
        {
            Assert.AreEqual("Саня, мы проебали корни", SquareSolution.SquareResult(5, 2, 7));
            Assert.AreEqual("Где иксы?", SquareSolution.SquareResult(0, 2, 2));
            Assert.AreEqual("0,25", SquareSolution.SquareResult(16, -8, 1));
            Assert.AreEqual("x1=1, x2=-3,5", SquareSolution.SquareResult(2, 5, -7));
        }
    }
}
