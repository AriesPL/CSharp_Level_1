using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork1._5;

namespace HomeWork2._2
{
	class Program
	{
		// Написать метод подсчета количества цифр.
		static void Main(string[] args)
		{
			
			LenghtValue();

			Pause.Stop();
		}

		private static void LenghtValue()
		{
			Random rnd = new Random();

			int x = rnd.Next(1000, 1000000000);
			string longValue = Convert.ToString(x);

			Print.Write("The length of '{0}' is '{1}'", longValue, longValue.Length);
		}
	}
}
