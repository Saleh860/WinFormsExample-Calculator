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
                result.Text = $" = {(double.Parse(first.Text) +
                    double.Parse(second.Text))}";
            }
            catch (FormatException)
            {
                result.Text = "Error";
            }
        }

        private void first_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 ||
                e.KeyChar >= '0'
                && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' &&
                !((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            double x = double.Parse(first.Text);
            double y = double.Parse(second.Text);
            result.Text = (x - y).ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double x = double.Parse(first.Text);
            double y = double.Parse(second.Text);
            result.Text = (x * y).ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            double x = double.Parse(first.Text);
            double y = double.Parse(second.Text);
            result.Text = (x / y).ToString();
        }
    }
}
