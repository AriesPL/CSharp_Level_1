using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._1
{

	// написать класс массивов, который принимает рандомные числа от -10000 до 10000 и ищет среди них пары делящиеся на 3
	class MyMas
	{
		
		int[] a;

		public MyMas(int size)
		{
			a = new int[size];
		}
		public MyMas(int size, int min, int max) //перегрузка с 3 паранитрами.
		{
			a = new int[size];
			Random rnd = new Random();

			for (int i = 0; i < size; i++)
			{
				a[i] = rnd.Next(min, max + 1);
			}

		}


		public int this[int index]// делаем метод для получения элемента массива через индексатор
		{
			get { return a[index]; }
			set { a[index] = value; }
		}

		public int Lenght //метод длины массива
		{
			get { return a.Length; }
		}
		public int Divisibility3() //метод сравнения массивов и поиску пар делящихся на 3
		{
			int count = 0;
			for (int i = 0; i < a.Length - 1; i++)
			{
				if (a[i] % 3 == 0 && a[i + 1] % 3 == 0 && a[i] != 0)
				{
					count++;
					Console.WriteLine("Пара {0} {1}", a[i], a[i + 1]);
				}
			}
			Console.WriteLine("Количество пар: " + count);
			return count;
		}
		public override string ToString()
		{
			string s = "";
			foreach (int element in a)
				s += element + " ";

			return s;
		}
		
		//Реализовать задание 1 ввиде статического класса.



	}
	class Program
	{

		static void Main(string[] args)
		{
			
			MyMas myMas = new MyMas(100, -10000, 10000);

			Console.WriteLine($"Создан массив чисел :\n {myMas} \n\nКакие массивы парные:");

			myMas.Divisibility3();
			


			Console.ReadLine();
		}
	}
}

