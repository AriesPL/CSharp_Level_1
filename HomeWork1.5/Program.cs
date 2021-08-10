using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork1._5
{
	class Program
	{
		static void Main(string[] args)
		{
			//Вывод Имя,Фамилию и город. Организовать вывод в центре консоли.
			Print print = new Print();// Создать свой класс Print
			Pause pause = new Pause();// Сщздать свой класс Pause
			
			int top, left;
			string info = "Sergeev Alexey. Tomsk city";
			
			left = Console.WindowWidth / 2;
			top = Console.WindowHeight / 2;
			
			Console.SetCursorPosition(left - info.Length/2, top);
			print.Write(info);

			pause.Stop();
		}
	}
}
