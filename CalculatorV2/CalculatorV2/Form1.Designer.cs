namespace CalculatorV2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.textBoxDisplay = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonClearTemp = new System.Windows.Forms.Button();
			this.buttonEquals = new System.Windows.Forms.Button();
			this.buttonPlus = new System.Windows.Forms.Button();
			this.buttonToPower = new System.Windows.Forms.Button();
			this.buttonTimes = new System.Windows.Forms.Button();
			this.buttonDivide = new System.Windows.Forms.Button();
			this.buttonMinus = new System.Windows.Forms.Button();
			this.buttonCloseParen = new System.Windows.Forms.Button();
			this.buttonOpenParen = new System.Windows.Forms.Button();
			this.buttonBackspace = new System.Windows.Forms.Button();
			this.buttonClearEverything = new System.Windows.Forms.Button();
			this.buttonNegate = new System.Windows.Forms.Button();
			this.buttonDecimal = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.textBoxDisplay);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Size = new System.Drawing.Size(371, 440);
			this.splitContainer1.SplitterDistance = 51;
			this.splitContainer1.TabIndex = 0;
			// 
			// textBoxDisplay
			// 
			this.textBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
			this.textBoxDisplay.Location = new System.Drawing.Point(3, 3);
			this.textBoxDisplay.Name = "textBoxDisplay";
			this.textBoxDisplay.ReadOnly = true;
			this.textBoxDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.textBoxDisplay.ShortcutsEnabled = false;
			this.textBoxDisplay.Size = new System.Drawing.Size(365, 55);
			this.textBoxDisplay.TabIndex = 0;
			this.textBoxDisplay.Text = "Enter Equation";
			this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonClearTemp);
			this.panel1.Controls.Add(this.buttonEquals);
			this.panel1.Controls.Add(this.buttonPlus);
			this.panel1.Controls.Add(this.buttonToPower);
			this.panel1.Controls.Add(this.buttonTimes);
			this.panel1.Controls.Add(this.buttonDivide);
			this.panel1.Controls.Add(this.buttonMinus);
			this.panel1.Controls.Add(this.buttonCloseParen);
			this.panel1.Controls.Add(this.buttonOpenParen);
			this.panel1.Controls.Add(this.buttonBackspace);
			this.panel1.Controls.Add(this.buttonClearEverything);
			this.panel1.Controls.Add(this.buttonNegate);
			this.panel1.Controls.Add(this.buttonDecimal);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button0);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(371, 385);
			this.panel1.TabIndex = 0;
			// 
			// buttonClearTemp
			// 
			this.buttonClearTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonClearTemp.Location = new System.Drawing.Point(83, 10);
			this.buttonClearTemp.Name = "buttonClearTemp";
			this.buttonClearTemp.Size = new System.Drawing.Size(65, 65);
			this.buttonClearTemp.TabIndex = 40;
			this.buttonClearTemp.Text = "C";
			this.buttonClearTemp.UseVisualStyleBackColor = true;
			this.buttonClearTemp.Click += new System.EventHandler(this.buttonClearTemp_Click);
			// 
			// buttonEquals
			// 
			this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonEquals.Location = new System.Drawing.Point(225, 294);
			this.buttonEquals.Name = "buttonEquals";
			this.buttonEquals.Size = new System.Drawing.Size(136, 65);
			this.buttonEquals.TabIndex = 39;
			this.buttonEquals.Text = "=";
			this.buttonEquals.UseVisualStyleBackColor = true;
			this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
			// 
			// buttonPlus
			// 
			this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonPlus.Location = new System.Drawing.Point(225, 223);
			this.buttonPlus.Name = "buttonPlus";
			this.buttonPlus.Size = new System.Drawing.Size(65, 65);
			this.buttonPlus.TabIndex = 38;
			this.buttonPlus.Text = "+";
			this.buttonPlus.UseVisualStyleBackColor = true;
			this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
			// 
			// buttonToPower
			// 
			this.buttonToPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonToPower.Location = new System.Drawing.Point(294, 10);
			this.buttonToPower.Name = "buttonToPower";
			this.buttonToPower.Size = new System.Drawing.Size(65, 65);
			this.buttonToPower.TabIndex = 37;
			this.buttonToPower.Text = "^";
			this.buttonToPower.UseVisualStyleBackColor = true;
			this.buttonToPower.Click += new System.EventHandler(this.buttonToPower_Click);
			// 
			// buttonTimes
			// 
			this.buttonTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonTimes.Location = new System.Drawing.Point(296, 223);
			this.buttonTimes.Name = "buttonTimes";
			this.buttonTimes.Size = new System.Drawing.Size(65, 65);
			this.buttonTimes.TabIndex = 36;
			this.buttonTimes.Text = "*";
			this.buttonTimes.UseVisualStyleBackColor = true;
			this.buttonTimes.Click += new System.EventHandler(this.buttonTimes_Click);
			// 
			// buttonDivide
			// 
			this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonDivide.Location = new System.Drawing.Point(296, 152);
			this.buttonDivide.Name = "buttonDivide";
			this.buttonDivide.Size = new System.Drawing.Size(65, 65);
			this.buttonDivide.TabIndex = 35;
			this.buttonDivide.Text = "/";
			this.buttonDivide.UseVisualStyleBackColor = true;
			this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
			// 
			// buttonMinus
			// 
			this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonMinus.Location = new System.Drawing.Point(225, 152);
			this.buttonMinus.Name = "buttonMinus";
			this.buttonMinus.Size = new System.Drawing.Size(65, 65);
			this.buttonMinus.TabIndex = 34;
			this.buttonMinus.Text = "-";
			this.buttonMinus.UseVisualStyleBackColor = true;
			this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
			// 
			// buttonCloseParen
			// 
			this.buttonCloseParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonCloseParen.Location = new System.Drawing.Point(294, 81);
			this.buttonCloseParen.Name = "buttonCloseParen";
			this.buttonCloseParen.Size = new System.Drawing.Size(65, 65);
			this.buttonCloseParen.TabIndex = 33;
			this.buttonCloseParen.Text = ")";
			this.buttonCloseParen.UseVisualStyleBackColor = true;
			this.buttonCloseParen.Click += new System.EventHandler(this.buttonCloseParen_Click);
			// 
			// buttonOpenParen
			// 
			this.buttonOpenParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonOpenParen.Location = new System.Drawing.Point(225, 81);
			this.buttonOpenParen.Name = "buttonOpenParen";
			this.buttonOpenParen.Size = new System.Drawing.Size(65, 65);
			this.buttonOpenParen.TabIndex = 32;
			this.buttonOpenParen.Text = "(";
			this.buttonOpenParen.UseVisualStyleBackColor = true;
			this.buttonOpenParen.Click += new System.EventHandler(this.buttonOpenParen_Click);
			// 
			// buttonBackspace
			// 
			this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonBackspace.Location = new System.Drawing.Point(154, 10);
			this.buttonBackspace.Name = "buttonBackspace";
			this.buttonBackspace.Size = new System.Drawing.Size(65, 65);
			this.buttonBackspace.TabIndex = 31;
			this.buttonBackspace.Text = "<-";
			this.buttonBackspace.UseVisualStyleBackColor = true;
			this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
			// 
			// buttonClearEverything
			// 
			this.buttonClearEverything.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonClearEverything.Location = new System.Drawing.Point(12, 10);
			this.buttonClearEverything.Name = "buttonClearEverything";
			this.buttonClearEverything.Size = new System.Drawing.Size(65, 65);
			this.buttonClearEverything.TabIndex = 30;
			this.buttonClearEverything.Text = "CE";
			this.buttonClearEverything.UseVisualStyleBackColor = true;
			this.buttonClearEverything.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonNegate
			// 
			this.buttonNegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonNegate.Location = new System.Drawing.Point(12, 294);
			this.buttonNegate.Name = "buttonNegate";
			this.buttonNegate.Size = new System.Drawing.Size(65, 65);
			this.buttonNegate.TabIndex = 29;
			this.buttonNegate.Text = "-";
			this.buttonNegate.UseVisualStyleBackColor = true;
			this.buttonNegate.Click += new System.EventHandler(this.buttonNegate_Click);
			// 
			// buttonDecimal
			// 
			this.buttonDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.buttonDecimal.Location = new System.Drawing.Point(154, 294);
			this.buttonDecimal.Name = "buttonDecimal";
			this.buttonDecimal.Size = new System.Drawing.Size(65, 65);
			this.buttonDecimal.TabIndex = 28;
			this.buttonDecimal.Text = ".";
			this.buttonDecimal.UseVisualStyleBackColor = true;
			this.buttonDecimal.Click += new System.EventHandler(this.buttonDecimal_Click);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.button9.Location = new System.Drawing.Point(154, 81);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(65, 65);
			this.button9.TabIndex = 27;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.button8.Location = new System.Drawing.Point(83, 81);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(65, 65);
			this.button8.TabIndex = 26;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.button7.Location = new System.Drawing.Point(12, 81);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(65, 65);
			this.button7.TabIndex = 25;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.button6.Location = new System.Drawing.Point(152, 152);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(65, 65);
			this.button6.TabIndex = 24;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.button5.Location = new System.Drawing.Point(83, 152);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(65, 65);
			this.button5.TabIndex = 23;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.button4.Location = new System.Drawing.Point(12, 152);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(65, 65);
			this.button4.TabIndex = 22;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.button3.Location = new System.Drawing.Point(152, 223);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(65, 65);
			this.button3.TabIndex = 21;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.button2.Location = new System.Drawing.Point(81, 223);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(65, 65);
			this.button2.TabIndex = 20;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.button1.Location = new System.Drawing.Point(12, 223);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(65, 65);
			this.button1.TabIndex = 19;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button0
			// 
			this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.button0.Location = new System.Drawing.Point(83, 294);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(65, 65);
			this.button0.TabIndex = 18;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.button0_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 440);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox textBoxDisplay;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonEquals;
		private System.Windows.Forms.Button buttonPlus;
		private System.Windows.Forms.Button buttonToPower;
		private System.Windows.Forms.Button buttonTimes;
		private System.Windows.Forms.Button buttonDivide;
		private System.Windows.Forms.Button buttonMinus;
		private System.Windows.Forms.Button buttonCloseParen;
		private System.Windows.Forms.Button buttonOpenParen;
		private System.Windows.Forms.Button buttonBackspace;
		private System.Windows.Forms.Button buttonClearEverything;
		private System.Windows.Forms.Button buttonNegate;
		private System.Windows.Forms.Button buttonDecimal;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button buttonClearTemp;
	}
}

