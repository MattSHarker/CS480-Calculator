using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorV2
{
	public partial class Form1 : Form
	{
		// used to know if the current display is an answer or input
		bool showingAnswer = true;

		// strings to hold the equations
		string tempString = "";
		string fullString = "";

		double finalAnswer = 0.0;

		object[] listOfElements;

		Stack stack;

		String[] strArray;

//		~~~~~~~~~~~~~~~~~~~~ Public Functions ~~~~~~~~~~~~~~~~~~~~

		public Form1()
		{
			InitializeComponent();
		}

		public bool checkForAnswer()
		{
			return showingAnswer;
		}

//		~~~~~~~~~~~~~~~~~~~~ Private Functions ~~~~~~~~~~~~~~~~~~~

		private void button0_Click_1(object sender, EventArgs e)
		{
			if (showingAnswer)
				clearDisplay();

			if (checkForOperator())
			{
				updateFullString();
				tempString += " ";
			}

			tempString += "0";
			updateDisplay();
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			if (showingAnswer)
				clearDisplay();

			if (checkForOperator())
			{
				updateFullString();
				tempString += " ";
			}

			tempString += "1";
			updateDisplay();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (showingAnswer)
				clearDisplay();

			if (checkForOperator())
			{
				updateFullString();
				tempString += " ";
			}

			tempString += "2";
			updateDisplay();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (showingAnswer)
				clearDisplay();

			if (checkForOperator())
			{
				updateFullString();
				tempString += " ";
			}

			tempString += "3";
			updateDisplay();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (showingAnswer)
				clearDisplay();

			if (checkForOperator())
			{
				updateFullString();
				tempString += " ";
			}

			tempString += "4";
			updateDisplay();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (showingAnswer)
				clearDisplay();

			if (checkForOperator())
			{
				updateFullString();
				tempString += " ";
			}

			tempString += "5";
			updateDisplay();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (showingAnswer)
				clearDisplay();

			if (checkForOperator())
			{
				updateFullString();
				tempString += " ";
			}

			tempString += "6";
			updateDisplay();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (showingAnswer)
				clearDisplay();

			if (checkForOperator())
			{
				updateFullString();
				tempString += " ";
			}

			tempString += "7";
			updateDisplay();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (showingAnswer)
				clearDisplay();

			if (checkForOperator())
			{
				updateFullString();
				tempString += " ";
			}

			tempString += "8";
			updateDisplay();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (showingAnswer)
				clearDisplay();

			if (checkForOperator())
			{
				updateFullString();
				tempString += " ";
			}

			tempString += "9";
			updateDisplay();
		}

		private void buttonDecimal_Click(object sender, EventArgs e)
		{
			if (showingAnswer)
				clearDisplay();

			if (checkForOperator())
				updateFullString();

			// only add the decimal if there isn't one
			if (!tempString.Contains("."))
			{
				// add the leading zero if empty for formatting purposes
				if (tempString == "")
					tempString += "0";
				tempString += ".";
			}

			updateDisplay();
		}

		// if the number is negative
		private void buttonNegate_Click(object sender, EventArgs e)
		{
			// only happen if tempString currently has a number
			if (checkForNumber())
			{
				if (tempString.StartsWith("-"))
					tempString = tempString.Remove(0, 1);
				else
					tempString = "-" + tempString;
				updateDisplay();
			}
		}

		private void buttonEquals_Click(object sender, EventArgs e)
		{
			updateFullString();
		}

		private void buttonPlus_Click(object sender, EventArgs e)
		{
			if (tempString.EndsWith("."))
				tempString += "0";

			if (!checkForOperator())
			{
				updateFullString();
				tempString = " +";
			}
			else
			{
				tempString = " +";
			}

			updateDisplay();
		}

		private void buttonMinus_Click(object sender, EventArgs e)
		{
			if (tempString.EndsWith("."))
				tempString += "0";

			if (!checkForOperator())
			{
				updateFullString();
				tempString = " -";
			}
			else
			{
				tempString = " -";
			}

			updateDisplay();
		}

		private void buttonTimes_Click(object sender, EventArgs e)
		{
			if (tempString.EndsWith("."))
				tempString += "0";

			if (!checkForOperator())
			{
				updateFullString();
				tempString = " *";
			}
			else
			{
				tempString = " *";
			}

			updateDisplay();

		}

		private void buttonDivide_Click(object sender, EventArgs e)
		{
			if (tempString.EndsWith("."))
				tempString += "0";

			if (!checkForOperator())
			{
				updateFullString();
				tempString = " /";
			}
			else
			{
				tempString = " /";
			}

			updateDisplay();
		}

		private void buttonOpenParen_Click(object sender, EventArgs e)
		{
			if (tempString.EndsWith("."))
				tempString += "0";

			if (!checkForOperator())
			{
				updateFullString();
				tempString = " ( ";
			}
			else
			{
				tempString = " (";
			}

			updateDisplay();
		}

		private void buttonCloseParen_Click(object sender, EventArgs e)
		{
			if (tempString.EndsWith("."))
				tempString += "0";

			if (!checkForOperator())
			{
				updateFullString();
				tempString = " )";
			}
			else
			{
				tempString = " )";
			}

			updateDisplay();
		}

		private void buttonToPower_Click(object sender, EventArgs e)
		{
			if (tempString.EndsWith(".") || tempString.EndsWith(". "))
				tempString += "0";

			if (!checkForOperator())
			{
				updateFullString();
				tempString = "^";
			}
			else
			{
				tempString = "^";
			}

			updateDisplay();
		}

		private void buttonBackspace_Click(object sender, EventArgs e)
		{
			if (tempString.Length > 0)
				tempString = tempString.Remove(tempString.Length-1, 1);
			else if (fullString.Length > 0)
					fullString = fullString.Remove(fullString.Length - 1, 1);
			
			updateDisplay();
		}

		// clears the entire entry
		private void buttonClear_Click(object sender, EventArgs e)
		{
			fullString = "";
			tempString = "";
			clearDisplay();
		}

		// clears only temp string
		private void buttonClearTemp_Click(object sender, EventArgs e)
		{
			tempString = "";
			updateDisplay();
		}

		// returns true if the most recent entry is a digit or .
		private bool checkForNumber()
		{
			return tempString.EndsWith("0") || tempString.EndsWith("1") ||
			       tempString.EndsWith("2") || tempString.EndsWith("3") ||
			       tempString.EndsWith("4") || tempString.EndsWith("5") ||
			       tempString.EndsWith("6") || tempString.EndsWith("7") ||
			       tempString.EndsWith("8") || tempString.EndsWith("9") ||
			       tempString.EndsWith(".");
		}

		// returns true if the most recent entry is an operator
		private bool checkForOperator()
		{
			return tempString.EndsWith("+") || tempString.EndsWith("-")
               ||  tempString.EndsWith("/") || tempString.EndsWith("*")
               ||  tempString.EndsWith("^") || tempString.EndsWith("(")
			   ||  tempString.EndsWith(")");
		}

		private void updateFullString()
		{
			fullString += tempString;
			tempString = "";
		}

		private void updateDisplay()
		{
			// get rid of the spaces in the display for 
			textBoxDisplay.Text = (fullString + " " + tempString).Replace(" ", "");
		}

		private void clearDisplay()
		{
			textBoxDisplay.Text = "";
			showingAnswer = false;
		}

		private void clearIfResult()
		{
			if (checkForAnswer())
				clearDisplay();
		}

		// change this to return sting
		private void prefixToPostfix(String prefix)
		{
			updateFullString();

			strArray = fullString.Split(' ');
			


			//stack = new Stack();
		}

		
//	~~~~~~~~~~~~~~~ infix/postfix functions ~~~~~~~~~~~~~~~

		private int precedence(char c)
		{
			if (c == '^')
				return 3;
			else if (c == '*' || c == '/')
				return 2;
			else if (c == '+' || c == '-')
				return 1;
			else
				return -1;
		}

	}
}