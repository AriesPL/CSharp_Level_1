using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._1
{
    class Complex
    {
        private double im;
        private double re;
        // Конструктор без параметров.
        public Complex()
        {
            im = 0;
            re = 0;
        }
        // Конструктор, в котором задаем поля.    
        public Complex(double im, double re)
        {
            this.im = im;
            this.re = re;
        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public  Complex Minus(Complex x2)
		{
            Complex x3 = new Complex();
            x3.im = x2.im - im;
            x3.re = x2.re - re;
            return x3;
		}

        public Complex Multiplication(Complex x2)
		{
            Complex x3 = new Complex();
            x3.im = x2.im * im;
            x3.re = x2.re * re;
            return x3;
		}

        public Complex Division(Complex x2)
		{
            Complex x3 = new Complex();
            x3.im = x2.im / im;
            x3.re = x2.re / re;
            return x3;
		}
        public double Im
        {
            get { return im; }
            set
            {
                // ограничивает только положительными числами.
                if (value >= 0) im = value;
            }
        }

        //метод, который возвращает строковое представление данных.
        public string Print()
        {
            if(im<0)
				return "\nОтвет :" + re  + im + "i\n\n";
			else
                return "\nОтвет :" + re + "+" + im + "i\n\n";
        }
    }
    class Program
	{
		public enum works
		{
			task0,
			task1,
			task2,
			task3,
			exit
		}

		public static works menu()
		{
			works worksResult = works.exit;
			string strResult;
			bool result = false;
			Console.WriteLine("Действия с комплехными числами:");
			Console.WriteLine("1 - Сложение ");
			Console.WriteLine("2 - Вычитание");
			Console.WriteLine("3 - Умножение");
			Console.WriteLine("4 - Деление");
			Console.WriteLine("5 - Выход ");

            do
            {
                strResult = Console.ReadLine();
                if (strResult == "1" || strResult == "2" || strResult == "3" || strResult == "4" || strResult == "5")
                    result = true;
            }
            while (!result);
            worksResult = (works)(Convert.ToInt32(strResult)-1);

            Console.Clear();
            return worksResult;
		}
		static void Main(string[] args)
		{
			/*Дописать структуру Complex: добавить методы - Вычитания и Произведения. 
										  добавить диалоговое окно switch демонстрирующее работу класса*/
			works choise;
			do
			{
				choise = menu();
				switch (choise)
				{
					case works.task0:
						ComplexPlus();
						break;
					case works.task1:
						ComplexMinus();
						break;
					case works.task2:
						ComplexMult();
						break;
					case works.task3:
						ComplexDiv();
						break;
					case works.exit:
						break;

				}
			}
			while (choise != works.exit);
			Console.WriteLine("Press any key to exit . . .");
			Console.ReadKey(true);

		}

		private static void ComplexDiv()
		{
			Complex complex1 = new Complex(1, 2);
			Complex complex2 = new Complex(2, 1);
			Complex resultDivision = complex1.Division(complex2);
			Console.WriteLine(resultDivision.Print());
		}

		private static void ComplexMult()
		{
			Complex complex1 = new Complex(1, 2);
			Complex complex2 = new Complex(2, 1);
			Complex resultMultiplication = complex1.Multiplication(complex2);
			Console.WriteLine(resultMultiplication.Print());
		}

		private static void ComplexMinus()
		{
			Complex complex1 = new Complex(1, 2);
			Complex complex2 = new Complex(2, 1);
			Complex resultMinus = complex1.Minus(complex2);
			Console.WriteLine(resultMinus.Print());
		}

		private static void ComplexPlus()
		{
			Complex complex1 = new Complex(1, 2);
			Complex complex2 = new Complex(2, 1);
			Complex resultPlus = complex1.Plus(complex2);
			Console.WriteLine(resultPlus.Print());
		}
	}
}
