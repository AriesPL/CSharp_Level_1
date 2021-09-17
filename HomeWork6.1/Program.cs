using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Переделать программу ПРИМЕР используя колекции для решения следующих задач:
 *Подсчитать кол-во студентов на 5 и 6 курсах.
 *Сколько студентов в возрасте от 18 до 20 на каком курсе учатся.
 *отсортировать по курсу и возрасту.
 */
namespace HomeWork6._1
{
	class Student
	{
		public string firstName;
		public string lastName;
		public string univercity;
		public string faculty;
		public string department;
		public int age;
		public int course;
		public int group;
		public string city;

		public Student(string firstName, string lastName, string univercity, string faculty, string department, int age, int course, int group, string city)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.univercity = univercity;
			this.faculty = faculty;
			this.department = department;
			this.age = age;
			this.course = course;
			this.group = group;
			this.city = city;
		}

		public override string ToString()
		{
			return String.Format(
				"Имя: {0}\n" +
				"Фамилия: {1}\n" +
				"Университет: {2}\n" +
				"Факультет: {3}\n" +
				"Депортамент: {4}\n" +
				"Возраст: {5}\n" +
				"Курс: {6}\n" +
				"Группа: {7}\n" +
				"Город: {8}\n", firstName, lastName, univercity, faculty, department, age, course, group, city);
		}
	}
	delegate bool ThisIs<T>(T s);
	class Program
	{
		static int MyMethod(Student st1, Student st2)
		{
			if (st1.age > st2.age) return 1;
			if (st1.age < st2.age) return -1;
			if (st1.course > st2.course) return 1;
			if (st1.course < st2.course) return -1;
			return 0;
		}


		static int MySort<T>(List<T> list, ThisIs<T> s)
		{
			int count = 0;
			foreach (var element in list)
			{
				if (s(element)) count++;
			}

			return count;
		}
		static void Main(string[] args)
		{
			int[] ageN = new int[35];
			int[] courseN = new int[6];

			int courses5 = 0;
			int courses6 = 0;

			List<Student> students = new List<Student>();
			StreamReader read = new StreamReader("students_4.csv");
			while (!read.EndOfStream)
			{
				try
				{
					string[] s = read.ReadLine().Split(';');
					Student student;
					student = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), Convert.ToInt32(s[6]), int.Parse(s[7]), s[8]);
					students.Add(student);
					if (student.course == 5) courses5++;
					if (student.course == 6) courses6++;

					if (student.age >= 18 && student.age <= 20) courseN[student.course - 1]++;

				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}
			read.Close();



			Console.WriteLine("Кол-во студентов на 5 курсах: {0}", courses5);
			Console.WriteLine("Кол-во студентов на 6 курсах: {0}", courses6);


			Console.WriteLine("Кол-во студентов в возрасте от 18 до 20:");
			for (int i = 0; i < courseN.Length; i++)
			{
				Console.WriteLine("На {0} курсе {1} студентов", i + 1, courseN[i]);
			}

			Console.WriteLine("Студенты по возрасту:\n");
			students.Sort(MyMethod);
			foreach (var sortStudents in students)
				Console.Write("Студент:{0} {1}. Его возраст: {2}\n", sortStudents.firstName, sortStudents.lastName, sortStudents.age);

			Console.WriteLine("Студенты младше 18 лет: {0}", MySort<Student>(students, delegate (Student s) { return s.age < 18; }));


			Console.ReadLine();
		}
	}
}
