using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._5
{
	class Program
	{
		//Програма которая вычисляет массу тела и рекомендует похудеть или набрать вес
		static void Main(string[] args)
		{
			float height, mass;

			InfoBody(out height, out mass);

			IndexMass(height, mass);

			Console.ReadLine();
		}

		private static void InfoBody(out float height, out float mass)
		{
			Console.WriteLine("Enter you height:");
			height = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter you mass");
			mass = int.Parse(Console.ReadLine());
		}

		private static void IndexMass(float height, float mass)
		{
			height /= 100;

			double indexMass = mass / (height * height);

			if (indexMass < 14.9)
				Console.WriteLine("Severe underweight - does not interfere with gaining weight");

			else if (indexMass > 15 && indexMass < 18.4)
				Console.WriteLine("Insufficient (deficiency) body weight - a little bit more");

			else if (indexMass > 18.5 && indexMass < 24.9)
				Console.WriteLine("Normal - That's all right.");

			else if (indexMass > 25 && indexMass < 29.9)
				Console.WriteLine("Overweight (pre-obesity) - Picked up a little");

			else if (indexMass > 30 && indexMass < 34.9)
				Console.WriteLine("Obesity 1 degree - bro you are in danger");

			else if (indexMass > 35 && indexMass < 39.9)
				Console.WriteLine("Obesity 2 degree - danger!");

			else if (indexMass > 40)
				Console.WriteLine("Obesity 3 degree - danger!!!!!");

			else
				Console.WriteLine("Out of range");
		}
	}
}
