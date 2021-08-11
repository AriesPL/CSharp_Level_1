using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork1._5;

namespace HomeWork2._1
{
	class Program
	{
		// Написать метод возвращающий минимальное число из 3 значений.
		static void Main(string[] args)
		{
			
			int x, y, z;
			RandomValue(out x, out y, out z);
			MinValue(x, y, z);

			Pause.Stop();
		}

		private static void RandomValue(out int x, out int y, out int z)
		{
			Random rnd = new Random();

			x = rnd.Next(1, 100);
			y = rnd.Next(1, 100);
			z = rnd.Next(1, 100);
			Print.Write("\nRandom value x ={0}, y = {1}, z = {2}.\n", x, y, z);
		}

		private static void MinValue(int x, int y, int z)
		{
			if (x < y && x < z)
				Print.Write("Min value x = {0}", x);

			else if (y < x && y < z)
				Print.Write("Min value y = {0}", y);

			else
				Print.Write("Min value z = {0}", z);
		}
	}
}
