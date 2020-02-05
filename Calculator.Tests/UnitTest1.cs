
using System;
using NUnit.Framework;

namespace CalculatorUnitTest
{
    public class CalculatorTests
    {
        [Test]
        public void TestAdd()
        {
            var test = new Calculator.Calculator();
            var result = test.Add(4, 3);
            Assert.AreEqual(7, result);
        }

        [Test]
        public void TestSubtract()
        {
            var test = new Calculator.Calculator();
            var result = test.Subract(4, 3);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestMultiply()
        {
            var test = new Calculator.Calculator();
            var result = test.Multiply(4, 4);
            Assert.AreEqual(16, result);
        }



        [Test]
        public void TestPower()
        {
            var test = new Calculator.Calculator();
            var result = test.Power(2, 4);
            Assert.AreEqual(16, result);
        }

        [Test]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void TestSquareRoot()
        {
            var test = new Calculator.Calculator();
            Assert.Throws<InvalidOperationException>(() => test.Squareroot(-4));

        }
    }
}
