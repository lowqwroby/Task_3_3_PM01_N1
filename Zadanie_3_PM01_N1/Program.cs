using System;

namespace Variant10
{
	class Program
	{

		static void f(double x, out double y)
		{
			if ((x + 2) <= 1) y = x * x;
			else if (1 < (x + 2) && (x + 2) < 10) y = 1 / (x + 2);
			else y = x + 2;
		}
		static double f(double x)
		{
			double y;
			if ((x + 2) <= 1) y = x * x;
			else if (1 < (x + 2) && (x + 2) < 10) y = 1 / (x + 2);
			else y = x + 2;
			return y;
		}

		static void Main(string[] args)
		{
			try
			{
				Console.Write("Введите а: ");
				double a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите b: ");
				double b = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите шаг h: ");
				double h = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("Вывод с помощью одного аргумента в функции");
				for (double i = a; i <= b; i += h)
				{
					Console.WriteLine("f({0:f2}) = {1:f4}", i, f(i));
				}

				Console.WriteLine("Вывод с помощью двух аргументов в функции");
				double y;
				for (double i = a; i <= b; i += h)
				{
					f(i, out y);
					Console.WriteLine("f({0:f2}) = {1:f4}", i, y);
				}
			}
			catch
			{
				Console.WriteLine("Введены некорректные данные.");
			}

		}
	}
}