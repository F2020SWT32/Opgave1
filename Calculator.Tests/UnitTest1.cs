
using System;
using NUnit.Framework;

namespace CalculatorUnitTest
{
	public class CalculatorTests
	{
		[TestCase(5,		3,		8)]
		[TestCase(2.5,		2.5,	5)]
		[TestCase(1.0/3,	2.0/3,	1)]
		public void TestAdd(double a, double b, double res)
		{
			var test = new Calculator.Calculator();
			var result = test.Add(a, b);
			Assert.AreEqual(res, result);
		}

		[TestCase(4, 3,	1)]
		[TestCase(4, 4, 0)]
		[TestCase(4, 3, 1)]
		public void TestSubtract(double a, double b, double res)
		{
			var test = new Calculator.Calculator();
			var result = test.Subract(a, b);
			Assert.AreEqual(res, result);
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
			Assert.Throws<InvalidOperationException>(() => test.Squareroot(-4));

		}
	}
}
