using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._7
{
	class Program
	{
		static void Main(string[] args)
		{
			//Рекурсивный метод который выводит на экран числа от (a < b)
			//Рекурсивный метод который считает суммы чисел от (a до b)
			int a = 1;
			int b = 100;
			int n = 1;
			Console.WriteLine("Number:");
			Number(a,b);

			Console.WriteLine("\nSum Number:");
			SumNumber(n, a, b);

			Console.ReadLine();
		}
		public static void Number(int a,int b)
		{
			
			Console.Write(" " + a);
			
			if (a < b)
				Number(a + 1,b);
			
		}

		public static void SumNumber(int n,int a,int b)
		{
			Console.Write(" " + n);
			a++;
			if (a <= b)
				SumNumber(n+a,a,b);
				
			
		}
	}
}
