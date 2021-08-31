using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork4._1
{

	// написать класс массивов, который принимает рандомные числа от -10000 до 10000 и ищет среди них пары делящиеся на 3
	class MyMas
	{

		int[] a;
		

		public MyMas(int size, int min)
		{
			int Sum = 0;
			a = new int[size];
			for (int i = 0; i < size; i++)
			{
				
				a[i] = min;
				min += 10;
				Sum += a[i];
			}
			Console.WriteLine("Сумма всех чисел в массиве = "+Sum);
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
	
		public void InversMyMas() //метод создающий копию первого но с отрицательными значениями
		{
			Console.WriteLine("Массив с отрицательным значением");
			int[] inversA = new int[Lenght];
			for (int i = 0; i < a.Length; i++)
			{
				inversA[i] = a[i] * -1;
				Console.Write(inversA[i]+" ");
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
			Console.WriteLine("Какие массивы парные: ");
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

		public void WriterToText(string filename) //Метод записи массива в txt-файл.
		{
			StreamWriter writertxt = new StreamWriter(filename);
			writertxt.WriteLine(a.Length);
			foreach (int element in a) writertxt.WriteLine(element);
			writertxt.Close();
		}

		public static void ReadToText(string filename) // Статический метод чтения txt-файла и выведение положительных массивов
		{
			try
			{
				StreamReader readertxt = new StreamReader(filename);
				int size = Convert.ToInt32(readertxt.ReadLine());
				int[] a = new int[size];
				Console.WriteLine("Из них положительные ");
				for (int i = 0; i < size; i++)
				{

					a[i] = Convert.ToInt32(readertxt.ReadLine());

					if (a[i] > 0)
						Console.Write(a[i] + " ");
				}
				readertxt.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine("Файл не найден " + e.Message);
			}
		} 

	}

	class Program
	{

		static void Main(string[] args)
		{


			MyMas myMas1 = new MyMas(100, -10000, 10000);

			myMas1.WriterToText("myMas1.txt");

			Console.WriteLine($"Создан массив чисел :\n {myMas1}");

			myMas1.Divisibility3();

			MyMas.ReadToText("myMas1.txt");

			Console.WriteLine("\nДлина массива?");
			int lenght = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Какой массив будет первым?");
			int value = Convert.ToInt32(Console.ReadLine());
			MyMas myMas = new MyMas(lenght, value);
			
			Console.WriteLine(myMas);

			myMas.InversMyMas();



			Console.ReadLine();

		}

		
	}
}


