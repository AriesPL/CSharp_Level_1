using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число:");
			int userInt;
			int sumUser =0;
			string strResult = "";
			do
			{
				bool flag;
				do
				{
					flag = Int32.TryParse(Console.ReadLine(), out userInt);
				}
				while (!flag);
				if (userInt % 2 != 0 && userInt > 0)
				{
					sumUser += userInt;
					strResult += Convert.ToString(userInt) + ", ";
				}
			}
			while (userInt != 0);

			Console.WriteLine(strResult);
			Console.WriteLine("Сумма нечетных положительных чисел {0}",sumUser);

			Console.ReadLine();
		}
	}
}
