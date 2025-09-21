using Microsoft.Maui.Graphics.Text;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        int i = 0;
        double z = 0;
        string x = "";
        bool znak;
        bool chislo = false;
        bool chet = false;
        public MainPage()
        {
            InitializeComponent();
            TextCalculator.Text = "0";

            BindingContext = this;

        }

        private void Seven(object sender, EventArgs e)
        {
            Noll("7");
        }

        private void Delete(object sender, EventArgs e)
        {
            if (TextCalculator.Text != "0")
            {

                int ii = TextCalculator.Text.Length - 1;

                if (ii >= 0)
                {
                    TextCalculator.Text = TextCalculator.Text.Remove(ii);
                    i--;

                    if (i >= 9)
                    {
                        TextCalculator.FontSize += 3;
                    }

                }
            }
            if (TextCalculator.Text.Length == 0)
                TextCalculator.Text = "0";
        }

        private void DeleteC(object sender, EventArgs e)
        {

            TextCalculator.Text = "";
            TextCalculatorHistory.Text = "";
            i = 0;
            x = "";
            znak = false;
            TextCalculator.FontSize = 65;
            TextCalculator.Text = "0";
        }

        private void DeleteCE(object sender, EventArgs e)
        {
            TextCalculator.Text = "";
            i = 0;
            TextCalculator.FontSize = 65;
            TextCalculator.Text = "0";
        }

        private void Procent(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(TextCalculator.Text, out value))
            {
                value = value / 100;
                TextCalculator.Text = value.ToString();
            }
        }

        private void Koren(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(TextCalculator.Text, out value) && value >= 0)
            {
                TextCalculator.Text = Math.Sqrt(value).ToString();
            }
            else
            {
                DisplayAlert("Ошибка", "Нельзя извлечь корень из отрицательного числа", "OK");
            }
        }

        private void Kvadrat(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(TextCalculator.Text, out value))
            {
                TextCalculator.Text = Math.Pow(value, 2).ToString();
            }
        }

        private void drob(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(TextCalculator.Text, out value) && value != 0)
            {
                TextCalculator.Text = (1 / value).ToString();
            }
            else
            {
                DisplayAlert("Ошибка", "Деление на ноль!", "OK");
            }
        }

        private void delenie(object sender, EventArgs e)
        {
            IsZnak("/");
        }

        private void eight(object sender, EventArgs e)
        {
            Noll("8");
        }

        private void nine(object sender, EventArgs e)
        {
            Noll("9");
        }

        private void umnozhenie(object sender, EventArgs e)
        {
            IsZnak("*");
            i = 0;
        }

        private void four(object sender, EventArgs e)
        {
            Noll("4");
        }

        private void five(object sender, EventArgs e)
        {
            Noll("5");
        }

        private void six(object sender, EventArgs e)
        {
            Noll("6");
        }

        private void minus(object sender, EventArgs e)
        {
            IsZnak("-");
            i = 0;

        }

        private void one(object sender, EventArgs e)
        {
            Noll("1");
        }

        private void two(object sender, EventArgs e)
        {
            Noll("2");
        }

        private void three(object sender, EventArgs e)
        {
            Noll("3");
        }

        private void plus(object sender, EventArgs e)
        {
            IsZnak("+");
            i = 0;
        }

        private void plusminus(object sender, EventArgs e)
        {
            if (TextCalculator.Text.StartsWith("-"))
                TextCalculator.Text = TextCalculator.Text.Substring(1);
            else if (TextCalculator.Text != "0")
                TextCalculator.Text = "-" + TextCalculator.Text;
        }

        private void zero(object sender, EventArgs e)
        {
            Noll("0");
        }

        private void zapataya(object sender, EventArgs e)
        {
            if (!TextCalculator.Text.Contains(","))
            {
                TextCalculator.Text += ",";
            }
        }

        private void ravno(object sender, EventArgs e)
        {
            if (!chet)
            {
                TextCalculatorHistory.Text += TextCalculator.Text + "=";
                Calculate();
                chet = true;
                znak = false;
            }
        }

        private void Resize()
        {
            i++;

            if (i >= 9 && i < 20)
            {
                TextCalculator.FontSize -= 3;
            }
        }
        public void IsZnak(string A)
        {
            if (!chet) Calculate();
            if (chet)
            {
                x = A;
                TextCalculatorHistory.Text = TextCalculator.Text + x;
            }
            else if (znak)
            {
                x = A;
                int ii = TextCalculatorHistory.Text.Length - 1;
                TextCalculatorHistory.Text = TextCalculatorHistory.Text.Remove(ii);
                TextCalculatorHistory.Text += x;
            }
            else
            {
                x = A;
                TextCalculatorHistory.Text += TextCalculator.Text + x;
                double.TryParse(TextCalculator.Text, out z);
            }
            chislo = false;
            znak = true;
            chet = false;
        }
        public void Noll(string A)
        {
            if (chet)
            {
                TextCalculatorHistory.Text = "";
                TextCalculator.Text = A;
            }
            else if (!chislo || TextCalculator.Text == "0")
            {
                TextCalculator.Text = A;
            }
            else
            {
                TextCalculator.Text += A;
                Resize();
            }
            chislo = true;
            znak = false;
            chet = false;
        }
        public void Calculate()
        {
            double icalculator;
            switch (x)
            {
                case "+":
                    double.TryParse(TextCalculator.Text, out icalculator);
                    TextCalculator.Text = (z += icalculator).ToString();
                    break;
                case "-":
                    double.TryParse(TextCalculator.Text, out icalculator);
                    TextCalculator.Text = (z -= icalculator).ToString();
                    break;
                case "*":
                    double.TryParse(TextCalculator.Text, out icalculator);
                    TextCalculator.Text = (z *= icalculator).ToString();
                    break;
                case "/":
                    double.TryParse(TextCalculator.Text, out icalculator);
                    TextCalculator.Text = (z /= icalculator).ToString();
                    break;

            };
        }


    }
}
