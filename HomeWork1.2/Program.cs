using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1._2
{
	class Program
	{
		//Расчитать массу человека по веденым росту и весу.
		static void Main(string[] args)
		{
			

			Console.WriteLine("Enter height:");
			float height = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter mass");
			float mass = Convert.ToInt32(Console.ReadLine());

			height /= 100;
			float indexMass = mass / (height * height) ; 

			Console.WriteLine("{0,0:f2}. You surprised me.", indexMass); 
			Console.ReadLine();
		}
	}
}
