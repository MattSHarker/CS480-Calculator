using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorV2
{
	public partial class Form1 : Form
	{
		// used to know if the current display is an answer or input
		bool showingAnswer = true;

		// strings to hold the equations
		private string tempString = "";
		private string fullString = "";
		private string postfixStr = "";

		private double finalAnswer = 0.0;

		object[] listOfElements;

		public Form1()
		{
			InitializeComponent();
		}

//		~~~~~~~~~~~~~~~~~~~~ Button Functions ~~~~~~~~~~~~~~~~~~~~

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
				int number;
				if (tempString == "" || !int.TryParse(tempString.Last().ToString(), out number)
									 || tempString.EndsWith("( "))
					tempString += "0";
				tempString += ".";
			}

			updateDisplay();
		}

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
			int number;

			if (tempString.EndsWith("."))
				tempString += "0";

			if (int.TryParse(tempString.Last().ToString(), out number))
			{
				tempString += " * ( ";
			}
			else if (tempString.EndsWith("( "))
			{
				tempString += "( ";
			}
			else
			{
				updateFullString();
				tempString = " ( ";
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
				tempString = " ^";
			}
			else
			{
				tempString = " ^";
			}

			updateDisplay();
		}

		private void buttonBackspace_Click(object sender, EventArgs e)
		{
			if (tempString.Length > 1)
			{
				if (tempString.EndsWith(" "))
					tempString = tempString.Remove(tempString.Length - 1, 1);
				
				tempString = tempString.Remove(tempString.Length - 1, 1);
			}
			else if (tempString.Length == 1)
			{
				if (tempString.EndsWith(" "))
					fullString = fullString.Remove(fullString.Length - 1, 1);

				tempString = tempString.Remove(tempString.Length - 1, 1);
			}
			else if (fullString.Length > 0)
			{
				if (fullString.EndsWith(" "))
					fullString = fullString.Remove(fullString.Length - 1, 1);
				
				fullString = fullString.Remove(fullString.Length - 1, 1);
			}

			updateDisplay();
		}

		private void buttonEquals_Click(object sender, EventArgs e)
		{
			updateFullString();

			try
			{
				String postfix = prefixToPostfix(fullString);
				double answer = calculatePostfix(postfix);
				textBoxDisplay.Text = answer.ToString();
			}
			catch (Exception exception)
			{
				textBoxDisplay.Text = "Syntax Error";
				Console.WriteLine(exception);
			}

			showingAnswer = true;
			fullString = "";
		}

		// clears fullString
		private void buttonClear_Click(object sender, EventArgs e)
		{
			fullString = "";
			tempString = "";
			clearDisplay();
		}

		// clears tempString
		private void buttonClearTemp_Click(object sender, EventArgs e)
		{
			tempString = "";
			updateDisplay();
		}


//		~~~~~~~~~~~~~~~~~~~~ Status Functions ~~~~~~~~~~~~~~~~~~~~

		private bool checkForAnswer()
		{
			return showingAnswer;
		}

		// returns true if the most recent entry is a digit or "."
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
			   || tempString.EndsWith("/") || tempString.EndsWith("*")
			   || tempString.EndsWith("^");
		}

		private void updateFullString()
		{
			fullString += tempString;
			fullString.Replace("  ", " "); // ensure there are no double spaces, to be safe
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


//		~~~~~~~~~~~~~~~~~~~~ infix/postfix Functions ~~~~~~~~~~~~~~~~~~~~

		private string prefixToPostfix(string str)
		{
			Stack stack = new Stack();
			string[] infixArray = str.Split(' ');

			foreach (var temp in infixArray)
			{
				switch (temp)
				{
					// operators
					case "+":
					case "-":
					case "*":
					case "/":
					case "^":
						while (stack.Count != 0 && (string)stack.Peek() != "("
							&& precedence(temp) <= precedence(stack.Peek().ToString()))
						{
							postfixStr += (stack.Pop() + " ");
						}

						stack.Push(temp);
						break;

					// open parenthesis
					case "(":
						stack.Push(temp);
						break;

					// closing parenthesis
					case ")":
						while (stack.Peek().ToString() != "(")
						{
							postfixStr += stack.Pop() + " ";
						}
						stack.Pop();
						break;

					// operands
					default:
						postfixStr += (temp + " ");
						break;

				} // end switch
			}

			while (stack.Count != 0)
			{
				postfixStr += stack.Pop() + " ";
			}

			return postfixStr.TrimEnd(' ');
		}

		private double calculatePostfix(string prefixString)
		{
			Stack stack = new Stack();
			string[] postfixArr = prefixString.Split(' ');

			foreach (var str in postfixArr)
			{
				double a, b, answer;
				if (str.ToString() == "+")
				{
					String aStr = stack.Pop().ToString();
					String bStr = stack.Pop().ToString();

					a = Convert.ToDouble(aStr);
					b = Convert.ToDouble(bStr);
					answer = b + a;
					stack.Push(answer);
				}

				else if (str.ToString() == "-")
				{
					String aStr = stack.Pop().ToString();
					String bStr = stack.Pop().ToString();
					a = Convert.ToDouble(aStr);
					b = Convert.ToDouble(bStr);
					answer = b - a;
					stack.Push(answer);
				}

				else if (str.ToString() == "*")
				{
					String aStr = stack.Pop().ToString();
					String bStr = stack.Pop().ToString();
					a = Convert.ToDouble(aStr);
					b = Convert.ToDouble(bStr);
					answer = b * a;
					stack.Push(answer);
				}

				else if (str.ToString() == "/")
				{
					String aStr = stack.Pop().ToString();
					String bStr = stack.Pop().ToString();
					a = Convert.ToDouble(aStr);
					b = Convert.ToDouble(bStr);
					answer = b / a;
					stack.Push(answer);
				}

				else if (str.ToString() == "^")
				{
					String aStr = stack.Pop().ToString();
					String bStr = stack.Pop().ToString();
					a = Convert.ToDouble(aStr);
					b = Convert.ToDouble(bStr);
					answer = Math.Pow(b, a);
					stack.Push(answer);
				}

				else
				{
					stack.Push(str);
				}
			}

			return Convert.ToDouble(stack.Pop());
		}

		private int precedence(String c)
		{
			if (c == "^")
				return 3;
			else if (c == "*" || c == "/")
				return 2;
			else if (c == "+" || c == "-")
				return 1;
			else
				return -1;
		}
	}
}