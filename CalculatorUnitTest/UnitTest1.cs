using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAdd()
        {
            var test = new Calculator.Calculator();
            var result = test.Add(4, 3);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            var test = new Calculator.Calculator();
            var result = test.Subract(4, 3);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            var test = new Calculator.Calculator();
            var result = test.Multiply(4, 4);
            Assert.AreEqual(16, result);
        }



        [TestMethod]
        public void TestPower()
        {
            var test = new Calculator.Calculator();
            var result = test.Power(2, 4);
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestSquareRoot()
        {
            var test = new Calculator.Calculator();
            var result = test.squareroot(-4);

        }
    }
}
