namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void add_Click(object sender, EventArgs e)
		{
			try
			{
				result.Text = $" {(double.Parse(first.Text) +
					double.Parse(second.Text))}";
			}
			catch (FormatException)
			{
				result.Text = "Error";
			}

		}

		private void subtract_Click(object sender, EventArgs e)
		{
			try
			{
				result.Text = $" {(double.Parse(first.Text) -
					double.Parse(second.Text))}";
			}
			catch (FormatException)
			{
				result.Text = "Error";
			}
		}

		private void milt(object sender, EventArgs e)
		{
			try
			{
				result.Text = $" {(double.Parse(first.Text) *
					double.Parse(second.Text))}";
			}
			catch (FormatException)
			{
				result.Text = "Error";
			}
		}

		private void devid(object sender, EventArgs e)
		{
			try
			{
				result.Text = $"{(double.Parse(first.Text) /
					double.Parse(second.Text))}";
			}
			catch (FormatException)
			{
				result.Text = "Error";
			}
		}

		private void submint(object sender, EventArgs e)
		{
			
		}
	}
}
