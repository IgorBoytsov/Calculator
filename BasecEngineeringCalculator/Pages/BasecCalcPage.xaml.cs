using System.Windows;
using System.Windows.Controls;

namespace BasecEngineeringCalculator.Pages
{
    /// <summary>
    /// Логика взаимодействия для BasecCalcPage.xaml
    /// </summary>
    public partial class BasecCalcPage : Page
    {
        public BasecCalcPage()
        {
            InitializeComponent();
        }

        double ArgumentOne;
        double ArgumentTwo;
        char Sign;
        double Result;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            txtBoxMain.Text += (string)button.Content;

        }

        private void Button_ClickClean(object sender, RoutedEventArgs e)
        {
            txtBoxMain.Clear();
        }

        private void Button_ClickCleanLast(object sender, RoutedEventArgs e)
        {
            if (txtBoxMain.Text != "")
            {
                txtBoxMain.Text = txtBoxMain.Text.Remove(txtBoxMain.Text.Length - 1);
            }
        }

        private void Button_ClickCleanAll(object sender, RoutedEventArgs e)
        {
            txtBoxMain.Clear();
            labelMain.Content = string.Empty;
            ArgumentOne = double.NaN;
            ArgumentTwo = double.NaN;
        }

        private void Button_Click_Division(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string SignButton = (string)button.Content;

            switch (SignButton)
            {
                case "/":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = string.Empty;
                        labelMain.Content = ArgumentOne + "/";
                        Sign = char.Parse(SignButton);
                    }
                    catch { }
                    break;
                case "*":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = string.Empty;
                        labelMain.Content = ArgumentOne + "*";
                        Sign = char.Parse(SignButton);
                    }
                    catch { }
                    break;
                case "-":
                    try
                    {
                        if (txtBoxMain.Text == "") txtBoxMain.Text += "-";
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = string.Empty;
                        labelMain.Content = ArgumentOne + "-";
                        Sign = char.Parse(SignButton);
                    }
                    catch { }
                    break;
                case "+":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = string.Empty;
                        labelMain.Content = ArgumentOne + "+";
                        Sign = char.Parse(SignButton);
                    }
                    catch { }
                    break;
            }
        }

        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            labelMain.Content = txtBoxMain.Text == "" ? "Вы ничего не ввели" : ArgumentTwo = double.Parse(txtBoxMain.Text);

            switch (Sign)
            {
                case '/':
                    Result = (ArgumentOne / ArgumentTwo);
                    txtBoxMain.Text = chekBoxRounding.IsChecked == true ? Result.ToString("F2") : Result.ToString("F0");
                    labelMain.Content = $"{ArgumentOne} / {ArgumentTwo} = ";
                    break;
                case '*':
                    Result = (ArgumentOne * ArgumentTwo);
                    txtBoxMain.Text = chekBoxRounding.IsChecked == true ? Result.ToString("F2") : Result.ToString("F0");
                    labelMain.Content = $"{ArgumentOne} * {ArgumentTwo} = ";
                    break;
                case '-':
                    Result = (ArgumentOne - ArgumentTwo);
                    txtBoxMain.Text = chekBoxRounding.IsChecked == true ? Result.ToString("F2") : Result.ToString("F0");
                    labelMain.Content = $"{ArgumentOne} - {ArgumentTwo}  = ";
                    break;
                case '+':
                    Result = (ArgumentOne + ArgumentTwo);
                    txtBoxMain.Text = chekBoxRounding.IsChecked == true ? Result.ToString("F2") : Result.ToString("F0");
                    labelMain.Content = $"{ArgumentOne} + {ArgumentTwo}  = ";
                    break;
            }
        }
    }
}
