using Microsoft.Maui.Graphics.Text;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        int i = 0;
        double z = 0;
        string x = "";
        public MainPage()
        {
            InitializeComponent();
            TextCalculator.Text = "0";

            BindingContext = this;

        }

        private void Seven(object sender, EventArgs e)
        {
            Noll("7");
            x = "";
        }

        private void Delete(object sender, EventArgs e)
        {
            if (TextCalculator.Text != "0")
            {

                int ii = TextCalculator.Text.Length-1;

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
            TextCalculator.Text = "0";
        }

        private void eight(object sender, EventArgs e)
        {
            Noll("8");
            x = "";


        }

        private void nine(object sender, EventArgs e)
        {
            Noll("9");
            x = "";

        }

        private void umnozhenie(object sender, EventArgs e)
        {

            IsZnak("*");
            TextCalculator.Text = "0";
            i = 0;
        }

        private void four(object sender, EventArgs e)
        {
            Noll("4");
            x = "";


        }

        private void five(object sender, EventArgs e)
        {
            Noll("5");
            x = "";


        }

        private void six(object sender, EventArgs e)
        {
            Noll("6");
            x = "";


        }

        private void minus(object sender, EventArgs e)
        {
            IsZnak("-");
            TextCalculator.Text = "0";
            i = 0;
  
        }

        private void one(object sender, EventArgs e)
        {
            Noll("1");
            x = "";


        }

        private void two(object sender, EventArgs e)
        {
            Noll("2");
            x = "";


        }

        private void three(object sender, EventArgs e)
        {
            Noll("3");
            x = "";


        }

        private void plus(object sender, EventArgs e)
        {
            IsZnak("+");
            TextCalculator.Text = "0";
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
            x = "";


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

            x = "";
        }

        private void Resize ()
        {
            i++;

            if (i >= 9 && i < 20)
            {
                TextCalculator.FontSize -= 3;
            }
        }
        public void IsZnak(string A)
        {
            if (x != "")
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
            }
        }
        public void Noll(string A)
        {
            if (TextCalculator.Text == "0")
            {
                TextCalculator.Text = A;
            }
            else
            {
                TextCalculator.Text += A;
                Resize();
            }
        }
        public void Calculate()
        {
            switch(x){
            };
        }


    }
}
