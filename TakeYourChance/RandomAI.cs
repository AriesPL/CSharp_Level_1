using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TakeYourChance
{
	class RandomAI
	{
		int count = 0;
		int current;
		int answer;

		public RandomAI()
		{

		}
		public RandomAI(int answer,int current)
		{
			this.answer = answer;
			this.current = current;
		}

		public string Comparison(int answer, int current)
		{
			
			if (answer > current && count != 5) { count++; return "Меньше";  }
			if (answer < current && count != 5) { count++; return "Больше"; }
			if (answer == current && count != 5) return "Верно. Использованно" + count + "попыток ";
			return "Колличество попыток истекло.";


		}

		public int Current 
		{
			get { return current; }
		}


		public int Answer
		{
			get { return answer; }
		}

	}
}
