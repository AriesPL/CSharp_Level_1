using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
/*
* Разработать статический класс Message содержащий статические методы:
* Вывести только те слова  сообщения , которые содержат n букв.
* Удалить все слова которые заканчиваются на заданный символ.
* Найти самый длинное солово в сообщение.
* Сформировать строку при помощи StringBuilder из самых длинных слов.
*/
namespace HomeWork5._2
{
	static class Message
	{

		public static void LongWord(string s, int value)
		{
			Regex regexText = new Regex(@"\b[A-ZА-Яа-яa-z]\w+\b");
			MatchCollection matchCollection = regexText.Matches(s);
			foreach (Match item in matchCollection)
				if (item.Length <= value) Console.Write(item + " ");
		}
		public static void DeleteWord(string s)
		{
			Regex regexTextDelete = new Regex(@"\b\w+[ь]\b");
			
			foreach (var item in regexTextDelete.Replace(s," "))
			{ 
				Console.Write(item);
			}
			Console.WriteLine("\nСлова которые были удалены:");
			foreach(var item in regexTextDelete.Matches(s))
			{
				Console.Write(item + " ");
			}

		}
		//public static void FindWord(string s)
		//{
		//	Regex regexLongWord = new Regex(@"\b\w+\b");
		//	MatchCollection matchCollection = regexLongWord.Matches(s);
		//	foreach (Match item in matchCollection)
		//	{
				
		//			Console.WriteLine(item);
				
				
				
		//	}
			

		//}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Какой длинный должны быть слова?");
			int lenghtWord = int.Parse(Console.ReadLine());
			string s = File.ReadAllText("music.txt");

			Message.LongWord(s, lenghtWord);

			Message.DeleteWord(s);

			//Message.FindWord(s);

			Console.ReadLine();
		}
	}
}
