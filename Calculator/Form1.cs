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

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
