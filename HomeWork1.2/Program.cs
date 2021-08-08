using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1._2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Расчитать массу человека по веденым росту и весу.

			Console.WriteLine("Enter height:");
			float height = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter mass");
			float mass = Convert.ToInt32(Console.ReadLine());

			float indexMass = ((height * height) / 100)/ mass; 

			Console.WriteLine("{0,0:f2}. You surprised me.", indexMass); 
			Console.ReadLine();
		}
	}
}
