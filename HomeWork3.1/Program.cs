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
				return re  + im + "i";
			else
                return re + "+" + im + "i";
        }
    }
    class Program
	{
  //      public enum works
  //      {
  //          task0,
  //          task1,
  //          task2,
  //          task3,
  //          exit
  //      }

  //      public static works menu()
		//{
  //          works worksResult = works.exit;
  //          int choose = 0;
  //          string strResult;
  //          bool result = false;
  //          Console.WriteLine("");
  //          Console.WriteLine("");
  //          Console.WriteLine("");
  //          Console.WriteLine("");
  //      }
        static void Main(string[] args)
		{
			/*Дописать структуру Complex: добавить методы - Вычитания и Произведения. 
										  добавить диалоговое окно switch демонстрирующее работу класса*/

   //         do
   //         {
   //             switch (choose)
   //             {
   //                 case 1:
   //                     break;

   //             }
   //         }
   //         while (!false);
			//{

			//}

            Complex complex1 = new Complex(1, 2);
            Complex complex2 = new Complex(2, 1);
            
            
            
            Complex resultPlus = complex1.Plus(complex2);
            Console.WriteLine(resultPlus.Print());

            Complex resultMinus = complex1.Minus(complex2);
            Console.WriteLine(resultMinus.Print());

            Complex resultMultiplication = complex1.Multiplication(complex2);
            Console.WriteLine(resultMultiplication.Print());

            Complex resultDivision = complex1.Division(complex2);
            Console.WriteLine(resultDivision.Print());

            Console.ReadLine();
        }
    }
}
