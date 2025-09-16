namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        int i = 0;
        int z; 
        public MainPage()
        {
            InitializeComponent();


            BindingContext = this;


        }

        private void Seven(object sender, EventArgs e)
        {
            TextCalculator.Text += "7";

            Resize();


        }


        private void Delete(object sender, EventArgs e)
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

        private void DeleteC(object sender, EventArgs e)
        {
            TextCalculator.Text = "";
            TextCalculatorHistory.Text = "";
            i = 0;
            TextCalculator.FontSize = 65;
        }

        private void DeleteCE(object sender, EventArgs e)
        {
            TextCalculator.Text = "";
            i = 0;
            TextCalculator.FontSize = 65;
        }

        private void Procent(object sender, EventArgs e)
        {

        }

        private void Koren(object sender, EventArgs e)
        {

        }

        private void Kvadrat(object sender, EventArgs e)
        {

        }

        private void drob(object sender, EventArgs e)
        {

        }

        private void delenie(object sender, EventArgs e)
        {

        }

        private void eight(object sender, EventArgs e)
        {
            TextCalculator.Text += "8";

            Resize();

        }

        private void nine(object sender, EventArgs e)
        {
            TextCalculator.Text += "9";

            Resize();

        }

        private void umnozhenie(object sender, EventArgs e)
        {

        }

        private void four(object sender, EventArgs e)
        {
            TextCalculator.Text += "4";

            Resize();

        }

        private void five(object sender, EventArgs e)
        {
            TextCalculator.Text += "5";

            Resize();

        }

        private void six(object sender, EventArgs e)
        {
            TextCalculator.Text += "6";

            Resize();

        }

        private void minus(object sender, EventArgs e)
        {

            TextCalculatorHistory.Text += TextCalculator.Text + "-";
            TextCalculator.Text = "";
            i = 0;
  
        }

        private void one(object sender, EventArgs e)
        {
            TextCalculator.Text += "1";

            Resize();

        }

        private void two(object sender, EventArgs e)
        {
            TextCalculator.Text += "2";

            Resize();

        }

        private void three(object sender, EventArgs e)
        {
            TextCalculator.Text += "3";

            Resize();

        }

        private void plus(object sender, EventArgs e)
        {

        }

        private void plusminus(object sender, EventArgs e)
        {

        }

        private void zero(object sender, EventArgs e)
        {
            TextCalculator.Text += "0";

            Resize();

        }

        private void zapataya(object sender, EventArgs e)
        {
            TextCalculator.Text += ",";

            Resize();
        }

        private void ravno(object sender, EventArgs e)
        {

        }

        private void Resize ()
        {
            i++;

            if (i >= 9 && i < 20)
            {
                TextCalculator.FontSize -= 3;
            }
        }
    }
}
