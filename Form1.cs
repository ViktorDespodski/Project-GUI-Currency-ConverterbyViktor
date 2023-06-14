namespace ViktorGUIConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const decimal CurrencyCoefficient = 1.95583m;
            decimal toEUR = numericUpDown1.Value / CurrencyCoefficient;
            label2.Text = $"{numericUpDown1.Value} BGN = {toEUR} EUR";
        }
    }
}