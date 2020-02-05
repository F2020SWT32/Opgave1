using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator calc = new Calculator();

			double a = 10;
			double b = 5;

			double result1 = calc.Add(a, b);
			double result2 = calc.Subract(a, b);
			double result3 = calc.Multiply(a, b);
			double result4 = calc.Power(a, b);

			Console.WriteLine($"Test of Add: {a} + {b} = {result1}");
			Console.WriteLine($"Test of Subtract: {a} - {b} = {result2}");
			Console.WriteLine($"Test of Multiply: {a} * {b} = {result3}");
			Console.WriteLine($"Test of Power: ({a})^{b} = {result4}");

			Console.ReadKey();
		}
	}


	public class Calculator
	{
		public double Accumulator { get; private set; }

		public Calculator()
		{
			Accumulator = 0;
		}
		public double Add(double a, double b)
		{
			return a + b;
		}
		public double Add(double a)
		{
			Accumulator += a;
			return Accumulator;
		}

		public double Subract(double a, double b)
		{
			return a - b;
		}

		public double Multiply(double a, double b)
		{
			return a * b;
		}

		public double Power(double x, double exp)
		{
			if(x == 0 && exp < 0)
				throw new ArgumentException("Exponent cant be negative if the base is 0");
			if(x < 0 && exp % 1.0 != 0)
				throw new ArgumentException("Exponent must be an integer if the base is negative");
			
			Accumulator = Math.Pow(x, exp);
			return Accumulator;
		}
		
		public double Power(double exp)
		{
			return Power(Accumulator, exp);
		}

		public double Divide(double a, double b)
		{
			if(b == 0)
				throw new DivideByZeroException();
			return a / b;
		}

		public double Squareroot(double a)
		{
			if (a < 0)
				throw new InvalidOperationException();
			return Math.Sqrt(a);
		}
	}



}
