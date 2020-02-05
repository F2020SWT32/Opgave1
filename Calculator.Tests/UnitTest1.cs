
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

        [TestCase(16, 4, 4)]
		[TestCase(-32, 8, -4)]
        public void TestDivide(double a, double b, double res)
        {
            var test = new Calculator.Calculator();
            var result = test.Divide(a, b);
            Assert.AreEqual(res, result);
            Assert.AreEqual(res, test._accumulator);

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
            Assert.AreEqual(res, test._accumulator);
        }

        [Test]
        public void TestDivideByZeroOverload()
        {
            var test = new Calculator.Calculator();
            Assert.Throws<DivideByZeroException>(() => test.Divide(0));
        }

        

		[TestCase(0,0)]
		[TestCase(0.01,0.1)]
		[TestCase(10, 3.16227766017)]
		public void TestSquareRoot(double a, double expected)
		{
			var test = new Calculator.Calculator();
			var result = test.Squareroot(a);
			Assert.AreEqual(result, expected, 0.00001);

		}

		[TestCase(0)]
		[TestCase(0.01)]
		[TestCase(10)]

		public void TestSquareRootEx()
		{
			var test = new Calculator.Calculator();
			Assert.Throws<InvalidOperationException>(() => test.Squareroot(-4));

		}
	}
}
