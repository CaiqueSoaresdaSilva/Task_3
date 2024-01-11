namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTemperatura.Controls.RemoveAt(0);
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            decimal TempCelcius = txtTemperatura.Value;
            decimal TempFahrenheit = 0;
            decimal TempKelvin = 0;

            TempFahrenheit = (9 * TempCelcius +160) / 5;

            TempKelvin = (TempCelcius + 273);

            lblResultF.Text = "Fahrenheit =" + TempFahrenheit;
            lblResultK.Text = "Kelvin =" + TempKelvin;

        }
    }
}
