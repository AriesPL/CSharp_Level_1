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
		static char[] simbol = { ',', '.', ' ', '\r','\n','!','?',':',';','(',')','-','+' };
		
		public static string FindWord(string s, int value) //ищет слова не больше заданого числа пользователем.
		{
			string[] text = s.Split(simbol,StringSplitOptions.RemoveEmptyEntries);
			string word = "";
			foreach (string item in text)
			{
				if (item.Length <= value) 
					word += item + " ";
			}
			return word;
		}
		public static string DeleteWord(string s, char c) //удаляет все слова заканчивающиеся на символ заданный пользователем.
		{
			string[] text = s.Split(simbol, StringSplitOptions.RemoveEmptyEntries);
			string newText = "";
			string findChar = c.ToString();
			foreach(string item in text)
			{
				if (!item.EndsWith(findChar))
					newText += item + ' ';
			}
			return newText;
		}
		static int WordMax(string s) // приватный метод поиска самого длинного слова в тексте.
		{
			string[] text = s.Split(simbol);
			int max = 0;
			foreach(string item in text)
			{
				if (item.Length > max)
					max = item.Length;
			}
			return max;
		}
		public static string LongWord(string s) //найденые слова склеиваются с использованием StringBilder
		{
			string[] text = s.Split(simbol);
			int wordMax = WordMax(s);
			StringBuilder sb = new StringBuilder();
			
			foreach(string item in text)
			{
				if (item.Length == wordMax)
					sb.Append(item + " ");
			}
			return sb.ToString();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			string s = File.ReadAllText("music.txt");

			Console.WriteLine("Какой длинный должны быть слова?");
			int lenghtWord = int.Parse(Console.ReadLine());
			Console.Write(Message.FindWord(s, lenghtWord));
			Console.ReadLine();
			Console.Clear();

			Console.WriteLine("\nНа какой символ не должно заканчиваться слово?");
			char deleteWord = char.Parse(Console.ReadLine());
			Console.Write(Message.DeleteWord(s, deleteWord));
			Console.ReadLine();
			Console.Clear();

			Console.WriteLine("\n\nСамые длинные слова в тексте:");
			Console.Write(Message.LongWord(s));
			Console.ReadLine();

		}
	}
}
