using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Используя Windows Forms разработать игру угадай число. 
 * Компьютер загадывает число от 1 до 100. Человек пытаеться угадать за минимальное число попыток.
 */
namespace TakeYourChance
{
	public partial class Form1 : Form
	{
		RandomAI rndAi = new RandomAI();
		Random rnd = new Random();
		int start;
		public Form1()
		{
			InitializeComponent();
			start = rnd.Next(1, 101);
		}
		

		private void btnEnter_Click(object sender, EventArgs e)
		{
			try
			{
				lb2.Text = rndAi.Comparison(Int32.Parse(tboxAnswer.Text), start);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
			}
			tboxAnswer.Clear();
		}

		
	}
}
