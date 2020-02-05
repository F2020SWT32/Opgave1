
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

		[Test]
		public void TestSquareRoot()
		{
			var test = new Calculator.Calculator();
			Assert.Throws<InvalidOperationException>(() => test.squareroot(-4));

		}
	}
}
