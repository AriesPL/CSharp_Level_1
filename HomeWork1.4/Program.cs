using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1._4
{
	class Program
	{
		//обмен значениями двух переменных с использованием третьей и без.
		static void Main(string[] args)
		{
			

			int x = 2;
			int y = 8;
			int z = 0;
			Print(x, y, z);

			Change(x, y, z);

			Change(x, y);

			Console.ReadLine();
		}

		private static void Print(int x, int y, int z)
		{
			
			Console.WriteLine("x = {0}\ny = {1}\nz = {2}", x, y,z);
		}
		private static void Change(int x, int y, int z)
		{
			z = x;
			x = y;
			y = z;

			Console.WriteLine("\nx = {0}\ny = {1}", x, y);
		}
		private static void Change(int x, int y)
		{
			x = x + y;
			y = x - y;
			x = x - y;

			Console.WriteLine("\nx = {0}\ny = {1}", x, y);
		}
	}
}
