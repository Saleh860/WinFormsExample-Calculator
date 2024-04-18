namespace stude_forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string value1 = "";
		string value2 = "";
		string use_dot = "yes";
		int times_used = 0;
		string type_opretion = "";
		private void button1_Click(object sender, EventArgs e)
		{
			text.Text = text.Text + "1";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			text.Text = text.Text + "2";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			text.Text = text.Text + "3";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			text.Text = text.Text + "4";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			text.Text = text.Text + "5";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			text.Text = text.Text + "6";
		}
		private void button7_Click(object sender, EventArgs e)
		{
			text.Text = text.Text + "7";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			text.Text = text.Text + "8";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			text.Text = text.Text + "9";
		}

		private void button0_Click(object sender, EventArgs e)
		{
			text.Text = text.Text + "0";
		}

		private void buttonDot_Click(object sender, EventArgs e)
		{
			if (use_dot == "yes")
			{
				text.Text = text.Text + ".";
			}
			use_dot = "no";
		}

		private void buttonplas_Click(object sender, EventArgs e)
		{
			type_opretion = "+";
			use_dot = "yes";
			if (times_used == 0)
			{
				value1 = text.Text;
				times_used++;
			}
			else
			{
				value2 = text.Text;
				value1 = findValue(value1, value2);
			}
			text.Text = "";
		}
		public string findValue(string value1, string value2)
		{
			use_dot = "yes";
			if (type_opretion == "+")
			{
				return (double.Parse(value1) + double.Parse(value2)).ToString();
			}
			else if (type_opretion == "-")
			{
				return (double.Parse(value1) - double.Parse(value2)).ToString();
			}
			else if (type_opretion == "*")
			{
				return (double.Parse(value1) * double.Parse(value2)).ToString();
			}
			else if (type_opretion == "/")
			{
				return (double.Parse(value1) / double.Parse(value2)).ToString();
			}
			else if (type_opretion == "%")
			{
				return (double.Parse(value2) / double.Parse(value1) * 100).ToString();
			}
			return "";
		}
		private void buttonEqual_Click(object sender, EventArgs e)
		{
			times_used = 0;
			value2 = text.Text;
			text.Text = findValue(value1, value2);
		}

		private void buttonSubtrat_Click(object sender, EventArgs e)
		{
			type_opretion = "-";
			use_dot = "yes";
			if (times_used == 0)
			{
				value1 = text.Text;
				times_used++;
			}
			else
			{
				value2 = text.Text;
				value1 = findValue(value1, value2);
			}
			text.Text = "";
		}

		private void buttonmultipli_Click(object sender, EventArgs e)
		{
			type_opretion = "*";
			use_dot = "yes";
			if (times_used == 0)
			{
				value1 = text.Text;
				times_used++;
			}
			else
			{
				value2 = text.Text;
				value1 = findValue(value1, value2);
			}
			text.Text = "";
		}

		private void buttonDivision_Click(object sender, EventArgs e)
		{
			type_opretion = "/";
			use_dot = "yes";
			if (times_used == 0)
			{
				value1 = text.Text;
				times_used++;
			}
			else
			{
				value2 = text.Text;
				value1 = findValue(value1, value2);
			}
			text.Text = "";
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			text.Text = "";
		}

		private void buttonNegative_Click(object sender, EventArgs e)
		{
			text.Text = "-" + text.Text;
		}

		private void buttonPercent_Click(object sender, EventArgs e)
		{
			type_opretion = "%";
			use_dot = "yes";
			if (times_used == 0)
			{
				value1 = text.Text;
				times_used++;
			}
			else
			{
				value2 = text.Text;
				value1 = findValue(value1, value2);
			}
			text.Text = "";
		}
	}
}
