
using System;
using NUnit.Framework;

namespace CalculatorUnitTest
{
	public class CalculatorTests
	{
		[TestCase(5,		3,		8, 1.0/1000000)]
		[TestCase(2.5,		2.5,	5, 1.0/1000000)]
		[TestCase(1.0/3,	2.0/3,	1, 1.0/1000000)]
		public void TestAdd(double a, double b, double res, double theta)
		{
			var test = new Calculator.Calculator();
			var result = test.Add(a, b);
			Assert.AreEqual(res, result, theta);
		}

		[Test]
		public void TestSubtract()
		{
			var test = new Calculator.Calculator();
			var result = test.Subract(4, 3);
			Assert.AreEqual(1, result);
		}

		[TestCase(15, 8, 120)]
		[TestCase(-7, 4, -28)]
        [TestCase(-8, -3, 24)]
		public void TestMultiply(double a, double b, double res)
		{
			var test = new Calculator.Calculator();
			var result = test.Multiply(a, b);
			Assert.AreEqual(res, result);
            Assert.AreEqual(res, test.Accumulator);
		}

        [TestCase(7, 7, 49)]
		[TestCase(8, -5, -40)]
        [TestCase(-4, -4, 16)]
		public void TestMultiplyOverload(double a, double multiplier, double res)
		{
			var test = new Calculator.Calculator();
            test.Add(0, a);
			var result = test.Multiply(multiplier);
			Assert.AreEqual(res, result);
            Assert.AreEqual(res, test.Accumulator);
		}

		[Test]
		public void TestPower()
		{
			var test = new Calculator.Calculator();
			var result = test.Power(2, 4);
			Assert.AreEqual(16, result);
		}

        [TestCase(16, 4, 4)]
		[TestCase(-32, 8, -4)]
        public void TestDivide(double a, double b, double res)
        {
            var test = new Calculator.Calculator();
            var result = test.Divide(a, b);
            Assert.AreEqual(res, result);
            Assert.AreEqual(res, test.Accumulator);

        }

        [Test]
        public void TestDivideByZero()
        {
            var test = new Calculator.Calculator();
            Assert.Throws<DivideByZeroException>(() => test.Divide(8, 0));
        }

        [TestCase(3, 7)]
		[TestCase(-7, -3)]
        public void TestDivideOverload(double divisor, double res)
        {
            var test = new Calculator.Calculator();
            test.Add(0, 21);
            var result = test.Divide(divisor);
            Assert.AreEqual(res, result);
            Assert.AreEqual(res, test.Accumulator);
        }

        [Test]
        public void TestDivideByZeroOverload()
        {
            var test = new Calculator.Calculator();
            Assert.Throws<DivideByZeroException>(() => test.Divide(0));
        }

        

		[Test]
		public void TestSquareRoot()
		{
			var test = new Calculator.Calculator();
			Assert.Throws<InvalidOperationException>(() => test.Squareroot(-4));

		}
	}
}
