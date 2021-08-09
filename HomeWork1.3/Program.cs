using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1._3
{
	class Program
	{
		static void Main(string[] args)
		{
			//Программа вычисления растояния между точками.
			ConWrite("Enter point x1:");
			int x1 = ConRead();

			ConWrite("Enter point x2:");
			int x2 = ConRead();

			ConWrite("Enter point y1:");
			int y1 = ConRead();

			ConWrite("Enter point y2:");
			int y2 = ConRead();

			double lenght = GetLenght(x1, x2, y1, y2);

			ConWrite("Distance between points {0,0:f2}", lenght);

			Console.ReadLine();
		}

		private static int ConRead()
		{
			return Convert.ToInt32(Console.ReadLine());
		}

		private static double GetLenght(int x1, int x2, int y1, int y2) // вывести вычисление в отдельный метод.
		{
			return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
		}

		private static void ConWrite(string v, double lenght)// Сделать перегрузку методов.
		{
			Console.WriteLine(v, lenght);
			
		}

		private static void ConWrite(string v)//Сделать перегрузку методов.
		{
			Console.WriteLine(v);
			
		}
		
		
			
		
	}
}
