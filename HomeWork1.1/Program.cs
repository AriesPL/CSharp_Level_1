using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1._1
{
	class Program
	{
		//Написать программу анкета.
		static void Main(string[] args)
		{
			

			Console.WriteLine("Enter you name:");
			string name = Convert.ToString(Console.ReadLine());

			Console.WriteLine("Enter second name:");
			string secname = Convert.ToString(Console.ReadLine());

			Console.WriteLine("Enter years:");
			int year = Convert.ToInt32(Console.ReadLine());

			int born = DateTime.Now.Year - year;

			Console.WriteLine("Enter height:");
			int height = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter mass");
			int mass = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Hi,"+ secname + " " + name + ". Nice to meet to you."); // Вывод склейкой.
			Console.WriteLine($"Now {year} years. You born in {born}."); // Вывод  со знаком $.
			Console.WriteLine("Your height {0} and mass {1}. Excellent result, you impressed me.",height,mass); // Форматированый вывод

			Console.ReadLine();
		}

		
	}
}
