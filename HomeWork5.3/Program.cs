using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
 * Написать статический метод палендром.  
 */
namespace HomeWork5._3
{
	
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Небольшой пример слов.");
			string leadText = File.ReadAllText("Palindrom.txt");
			foreach (char item in leadText)
			{
				Console.Write(item);
			}

			Console.WriteLine("\nВведите слово палиндром или любое другое:");

			string a = Convert.ToString(Console.ReadLine());
			if (a.Length > 3)
			{
				if (Palindrom(a)) Console.WriteLine("Это полиндром.");
				else Console.WriteLine("Нет.");
			}
			else Console.WriteLine("Слишком коротко.");
			Console.ReadLine();
		}
		static bool Palindrom(string s, bool ignoreCase = true)
		{
			var reversedWord = new string(s.Reverse().ToArray());
			bool result;
			if (ignoreCase)
			{
				result = reversedWord.Equals(s, StringComparison.InvariantCultureIgnoreCase);
			}
			else
			{
				result = reversedWord.Equals(s);
			}

			return result;
		}
		
		
	}
}
