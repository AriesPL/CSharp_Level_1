using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork1._5
{
	class Program
	{
		//Вывод Имя,Фамилию и город. Организовать вывод в центре консоли.
		static void Main(string[] args)
		{
			
			
			
			
			int top, left;
			string info = "Sergeev Alexey. Tomsk city";
			
			left = Console.WindowWidth / 2;
			top = Console.WindowHeight / 2;
			
			Console.SetCursorPosition(left - info.Length/2, top);
			Print.Write(info); // Создать свой класс Print

			Pause.Stop(); // Создать свой класс Pause
		}
	}
}
