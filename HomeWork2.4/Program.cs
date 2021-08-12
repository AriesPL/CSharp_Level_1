using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._4
{
	class Program
	{
		static void Main(string[] args)
		{
			//Метод проверки логина и пароля. log = root ; pass = 12345

			LogPas();

			Console.ReadLine();

		}

		private static void LogPas()
		{
			string log, pass;
			int count = 0;
			do
			{
					Console.WriteLine("Enter Login:");
					log = Console.ReadLine();

					Console.WriteLine("Enter Password:");
					pass = Console.ReadLine();

					count++;
			}
			while (log != "root" && pass != "12345" && count != 3);

			if (log == "root" && pass == "12345")
			{
				Console.WriteLine("You entered");
			}
			else
				Console.WriteLine("you used {0} tries", count);


		}
	}
}
