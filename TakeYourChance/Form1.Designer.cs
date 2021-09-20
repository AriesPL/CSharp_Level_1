
namespace TakeYourChance
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tboxAnswer = new System.Windows.Forms.TextBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lb2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tboxAnswer
			// 
			this.tboxAnswer.Location = new System.Drawing.Point(28, 58);
			this.tboxAnswer.Name = "tboxAnswer";
			this.tboxAnswer.Size = new System.Drawing.Size(100, 22);
			this.tboxAnswer.TabIndex = 0;
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(146, 57);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(75, 23);
			this.btnEnter.TabIndex = 1;
			this.btnEnter.Text = "Enter";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Я загадал число от 1 до 100";
			// 
			// lb2
			// 
			this.lb2.AutoSize = true;
			this.lb2.Location = new System.Drawing.Point(25, 94);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(48, 17);
			this.lb2.TabIndex = 3;
			this.lb2.Text = "Ответ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lb2);
			this.groupBox1.Controls.Add(this.tboxAnswer);
			this.groupBox1.Controls.Add(this.btnEnter);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(291, 179);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(332, 25);
			this.toolStrip1.TabIndex = 5;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(332, 203);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Take Your Chance";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tboxAnswer;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}

