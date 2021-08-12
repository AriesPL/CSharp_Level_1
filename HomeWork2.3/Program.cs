using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HomeWork1._5;

namespace HomeWork2._3
{
	class Program
	{
		static void Main(string[] args)
		{
			//Посчитать сумму всех нечетных положительных чисел, водяться пока не будет ввседен 0.

			int x, z = 0;
			
			Console.WriteLine("Enter number:");

			do
			{ 
				x = int.Parse(Console.ReadLine());
				
				if(x % 2 != 0 && x > 0)
				{
					z += x;
				}
			}

			while (x != 0);

			Console.WriteLine("The sum of all odd numbers all: {0} ",z);

			Pause.Stop();	
		}
	}
}
