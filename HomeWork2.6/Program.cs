using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._6
{
	class Program
	{
		// Программа для подсчета хороших чисел в диапозоне от 1 до 1 000 000 000.
		static void Main(string[] args)
		{

			int minNow = DateTime.Now.Minute;
			int minValue = 1;
			int maxValue = 1000000000;
            int gns_amount = 0;
            int amountNumbers = 0;

            Console.WriteLine("\nNumber of Good Numbers ranging from 1 to 1,000,000,000");
			Console.WriteLine("{0} minute now",minNow);
                for (int i = minValue; i < maxValue; i++)
                {
                    amountNumbers = CalculateNumbers(i);
                    if ((i % amountNumbers) == 0)
                        gns_amount++;
                }
			int minLast = Math.Abs(DateTime.Now.Minute - minNow);

			Console.WriteLine("amounted to {0:N0} pieces", gns_amount);
			Console.WriteLine("{0} Minute have passed", minLast);

            Console.ReadLine();
		}

		private static int CalculateNumbers(int i)
		{
			int count = 0;
			while (i > 0)
			{
				i = i / 10;
				count++;
			}
			return count;

		}
	}
}
