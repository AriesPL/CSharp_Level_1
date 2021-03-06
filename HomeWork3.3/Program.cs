using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._3
{
	class Program
	{
		//Описать класс дробей и взаимодействие с ними.
		class Drob
		{
			public double number = 0;
			public double denumber = 0;
			public double answer;


			public Drob()
			{

			}

			public Drob(int a, int b)
			{	
					number = a;
					denumber = b;
			}
			public override string ToString()//cтроковое представление
			{
				return $" {number} / {denumber}";
			}

			public string Answer()
			{
				return $" = {answer} ";
			}




			public static Drob operator +(Drob a, Drob b)//сложение дробей
			{

				Drob drobPlus = new Drob(1,1);//создание и инициализация новой дроби
				drobPlus.number = a.number * b.denumber + a.denumber * b.number;//числитель новой дроби
				drobPlus.denumber = a.denumber * b.denumber;//знаменатель новой дроби
				SetFormat(drobPlus);//сокращаем дробь
				drobPlus.answer = drobPlus.number / drobPlus.denumber;
				return drobPlus;//возвращаем результат
			}
			public static Drob operator -(Drob a, Drob b)//вычитание дробей
			{
				Drob drobMinus = new Drob(1,1);//создание и инициализация новой дроби
				drobMinus.number = a.number * b.denumber - a.denumber * b.number;//числитель новой дроби
				drobMinus.denumber = a.denumber * b.denumber;//знаменатель новой дроби
				SetFormat(drobMinus);//сокращаем дробь
				drobMinus.answer = drobMinus.number / drobMinus.denumber;
				return drobMinus;//возвращаем результат
			}
			public static Drob operator *(Drob a, Drob b)//вычитание дробей
			{
				Drob drobMult = new Drob(1,1);//создание и инициализация новой дроби
				drobMult.number = a.number * b.number;//числитель новой дроби
				drobMult.denumber = a.denumber * b.denumber;//знаменатель новой дроби
				SetFormat(drobMult);//сокращаем дробь
				drobMult.answer = drobMult.number / drobMult.denumber;
				return drobMult;//возвращаем результат
			}
			public static Drob operator /(Drob a, Drob b)//вычитание дробей
			{
				Drob drobDiv = new Drob(1,1);//создание и инициализация новой дроби
				drobDiv.number = (a.number / b.number);//числитель новой дроби
				drobDiv.denumber = a.denumber / b.denumber;//знаменатель новой дроби
				SetFormat(drobDiv);//сокращаем дробь
				drobDiv.answer = drobDiv.number / drobDiv.denumber;
				return drobDiv;//возвращаем результат
			}
			
		}

		static Drob SetFormat(Drob a)
			{

				double max = 0;

				//выбираем что больше числитель или знаменатель
				if (a.number > a.denumber)
					max = Math.Abs(a.denumber);//ВНИМАНИЕ! берем по модулю, что работало и с отрицательными
				else
					max = Math.Abs(a.number);//ВНИМАНИЕ! берем по модулю, что работало и с отрицательными
											 //поиск от максимума до 2
				for (double i = max; i >= 2; i--)
				{
					//такого числа, поделив на которое бы делилось без
					//остатка и на числитель и на знаменатель
					if ((a.number % i == 0) & (a.denumber % i == 0))
					{
						a.number = (int)(a.number / i);
						a.denumber = (int)(a.denumber / i);
					}

				}
				//Определяемся со знаком
				//если в знаменателе минус, поднимаем его наверх
				if (a.denumber < 0)
				{
					a.number = -1 * a.number;
					a.denumber = Math.Abs(a.denumber);

				}
				return a;//возращаем результат
			}


		public enum pick //перечисление
		{
			drobPlus,
			drobMinus,
			drobMulti,
			drobDiv,
			exit
		}
		public static pick menu() // меню с бесконечным циклом пока не будет введена кнопка отвечающая за выход
		{
			pick pickResult = pick.exit;
			string strResult;
			bool result = false;
			Console.WriteLine("Действия с дробями:");
			Console.WriteLine("1 - Сложение ");
			Console.WriteLine("2 - Вычитание");
			Console.WriteLine("3 - Умножение");
			Console.WriteLine("4 - Деление");
			Console.WriteLine("5 - Выход ");

			do 
			{
				strResult = Console.ReadLine();  //считываем введеные данные
				if (strResult == "1" || strResult == "2" || strResult == "3" || strResult == "4" || strResult == "5")
					result = true;
			}
			while (!result);
			pickResult = (pick)(Convert.ToInt32(strResult) - 1);

			Console.Clear();
			return pickResult;
		}


		static void Main(string[] args)
			{
				Drob drob1 = new Drob();
				Drob drob2 = new Drob();
				Drob drob3;
			
				Console.WriteLine("Введите числитель первой дроби:");
				drob1.number = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите знаминатель первой дроби:");
				drob1.denumber = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Введите числитель второй дроби:");
				drob2.number = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите знаминатель второй дроби:");
				drob2.denumber = Convert.ToInt32(Console.ReadLine());

			try 
			{
				if (drob1.number >= 1 && drob1.denumber >= 1 && drob2.number >= 1 && drob2.denumber >= 1)
				{
					Console.WriteLine(drob1.ToString());
					Console.WriteLine(drob2.ToString());
					pick choise;
					do
					{
						choise = menu();
						switch (choise)
						{
							case pick.drobPlus:
								drob3 = drob1 + drob2;
								Console.WriteLine($" Сложение {drob3.ToString()} {drob3.Answer()}");
								break;
							case pick.drobMinus:
								drob3 = drob1 - drob2;
								Console.WriteLine($" Вычитание {drob3.ToString()} {drob3.Answer()}");
								break;
							case pick.drobMulti:
								drob3 = drob1 * drob2;
								Console.WriteLine($" Умножение {drob3.ToString()} {drob3.Answer()}");
								break;
							case pick.drobDiv:
								drob3 = drob1 / drob2;
								Console.WriteLine($" Деление {drob3.ToString()} {drob3.Answer()}");
								break;
							case pick.exit:
								break;

						}
					}


					while (choise != pick.exit);
					Console.WriteLine("Press any key to exit . . .");
					Console.ReadLine();
				}
				else
				{
					Console.WriteLine(drob1.ToString());
					Console.WriteLine(drob2.ToString());
				}
			}
			finally
			{
				Console.WriteLine("Чеслитеть или знаменатель не может равняться 0.");
			}
			Console.ReadLine();
		}
	}
}



