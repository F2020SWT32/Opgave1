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

		public void Clear()
		{
			Accumulator = 0;
		}

		public double Add(double a, double b)
		{
			Accumulator = a + b;
			return Accumulator;
		}

		public double Add(double a)
		{
			Accumulator = Add(Accumulator, a);
			return Accumulator;
		}

		public double Subract(double a, double b)
		{
			Accumulator = a - b;
			return Accumulator;
		}

		public double Subtract(double a)
		{
			Accumulator = Subract(Accumulator, a);
			return Accumulator;
		}

		public double Multiply(double a, double b)
		{
			Accumulator = a * b;
			return Accumulator;
		}

		public double Multiply(double multiplier)
		{
			Accumulator = Accumulator * multiplier;
			return Accumulator;
		}

		public double Divide(double a, double b)
		{
			if(b == 0)
				throw new DivideByZeroException();
			Accumulator = a / b;
			return Accumulator;
		}

		public double Divide(double divisor)
		{
			if(divisor == 0)
				throw new DivideByZeroException();

			Accumulator = Accumulator/divisor;
			return Accumulator;
		}

		public double Power(double x, double exp)
		{
			if(x == 0 && exp < 0)
				throw new InvalidOperationException("Exponent cant be negative if the base is 0");
			if(x < 0 && exp % 1.0 != 0)
				throw new InvalidOperationException("Exponent must be an integer if the base is negative");
			
			Accumulator = Math.Pow(x, exp);
			return Accumulator;
		}
		
		public double Power(double exp)
		{
			return Power(Accumulator, exp);
		}

		public double Squareroot(double a)
		{
			if (a < 0)
				throw new InvalidOperationException();
			Accumulator = Math.Sqrt(a);
			return Accumulator;
		}

		public double Squareroot()
		{
			Accumulator = Math.Sqrt(Accumulator);
			return Accumulator;
		}

	}
}
