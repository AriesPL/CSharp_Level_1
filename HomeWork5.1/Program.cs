using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/*
 * Написать программу проверки параля. Что бы длина была 2-10. Содержал только буквы и цифры только латинского алфавита. Цифра не должна быть началом.
 * Без использования регулярного выражения.
 * С использованием регулярного выражения.
*/
namespace HomeWork5._1
{
	class Program
	{
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				Console.WriteLine("Введите пароль:");
				string s = Console.ReadLine();
				if (Check(s)) Console.WriteLine("При помощи не регулярных выражений, проверка пройдена."); else Console.WriteLine("No");
				if (RegularCheck(s)) Console.WriteLine("При помощи регулярных выражений, проверка пройдена."); else Console.WriteLine("No");
				Console.WriteLine("Нажмите Escape что бы выйти или любую клавишу что бы повторить.");

				Console.ReadLine();
			}
			while (Console.ReadKey().Key != ConsoleKey.Escape);
			
		}
		static public bool RegularCheck(string s) //статичная проверка для регулярного выражения.
		{
			Regex regCheck = new Regex(@"^[A-Za-z][A-Za-z0-9]{0,9}$"); // шаблон регулярного выражения.
			return regCheck.IsMatch(s); // проверка соответствует ли строка шаблону.
		}
		static public bool Check(string s) //статичная проверка соответствия без регулярного вырожения.
		{
			if (s.Length < 2 || s.Length > 10) return false; //проверка соответствие длинны строки
				if (char.IsDigit(s[0])) return false; //проверка что бы первым симфолом было не число
			for (int i = 1; i < s.Length; i++)
			{
				if (!char.IsLetterOrDigit(s[i]) || !LatinCheck(s[i])) return false; //проверка на то что символы Юникода относяться к букве или числу. 
				
			}

			return true;	
		}
		static bool LatinCheck(char s) //проверка на соответствие латинице.
		{
			s = char.ToUpper(s);
			return s >= 'A' && s <= 'Z' || char.IsDigit(s);

		}
		
	}
}

