using System;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Windows.ApplicationModel.Background;

namespace BasecEngineeringCalculator.Pages
{
    /// <summary>
    /// Логика взаимодействия для EngineeringCalcPage.xaml
    /// </summary>
    public partial class EngineeringCalcPage : Page
    {
        public EngineeringCalcPage()
        {
            InitializeComponent();
        }

        double ArgumentOne;
        double ArgumentTwo;
        string Sign;
        double Result;

        private void Button_Click_Get_Number(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            txtBoxMain.Text += (string)button.Content;

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

        private void Button_Click_Get_Sign(object sender, RoutedEventArgs e)
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
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "*":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = string.Empty;
                        labelMain.Content = ArgumentOne + "*";
                        Sign = SignButton;
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
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "+":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = string.Empty;
                        labelMain.Content = ArgumentOne + "+";
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "^":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = string.Empty;
                        labelMain.Content = ArgumentOne + "^";
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "n!":
                    ;
                    try
                    {
                        BigInteger n = BigInteger.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = Factorial(n).ToString();
                        labelMain.Content = n + "!";
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "asin":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        if (ArgumentOne <= 1 & ArgumentOne >= -1)
                        {
                            txtBoxMain.Text = Math.Asin(ArgumentOne).ToString();
                            labelMain.Content = $"Asin({ArgumentOne}) = ";
                            Sign = SignButton;
                        }
                        else
                        {
                            labelMain.Content = "Число должно быть от -1 до 1";
                            txtBoxMain.Text = string.Empty;
                        }        
                    }
                    catch { }
                    break;

                case "sin":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        double angleRadians = (Math.PI * ArgumentOne) / 180;
                        txtBoxMain.Text = Math.Sin(angleRadians).ToString("");
                        labelMain.Content = $"Sin({ArgumentOne}) = ";
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "1/x":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = (1 / ArgumentOne).ToString();
                        labelMain.Content = $"1/({ArgumentOne}) = ";
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "acos":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        if (ArgumentOne <= 1 & ArgumentOne >= -1)
                        {
                            txtBoxMain.Text = Math.Acos(ArgumentOne).ToString();
                            labelMain.Content = $"Acos({ArgumentOne}) = ";
                            Sign = SignButton;
                        }
                        else
                        {
                            labelMain.Content = "Число должно быть от -1 до 1";
                            txtBoxMain.Text = string.Empty;
                        }                      
                    }
                    catch { }
                    break;

                case "cos":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        double angleRadians = (Math.PI * ArgumentOne) / 180;
                        txtBoxMain.Text = Math.Cos(angleRadians).ToString();
                        labelMain.Content = $"Cos({ArgumentOne}) = ";
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "√":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        if (ArgumentOne >= 1)
                        {
                            txtBoxMain.Text = Math.Sqrt(ArgumentOne).ToString();
                            labelMain.Content = $"√({ArgumentOne}) = ";
                            Sign = SignButton;
                        }
                        else
                        {
                            labelMain.Content = "Число должно быть >0";
                            txtBoxMain.Text = string.Empty;
                        }                 
                    }
                    catch { }
                    break;

                case "atan":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = Math.Atan(ArgumentOne).ToString();
                        labelMain.Content = $"Atan({Math.Atan(ArgumentOne) * 180 / Math.PI})°";
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "tan":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        double angleRadians = (Math.PI * ArgumentOne) / 180;
                        txtBoxMain.Text = Math.Tan(angleRadians).ToString();
                        labelMain.Content = $"Tg({ArgumentOne}) = ";
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "ln":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = Math.Log(ArgumentOne).ToString();
                        labelMain.Content = $"Ln({ArgumentOne}) = ";
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "lg":
                    try
                    {
                        ArgumentOne = double.Parse(txtBoxMain.Text);
                        txtBoxMain.Text = Math.Log10(ArgumentOne).ToString();
                        labelMain.Content = $"Log({ArgumentOne}) = ";
                        Sign = SignButton;
                    }
                    catch { }
                    break;

                case "π":
                        txtBoxMain.Text += Math.PI.ToString();
                    break;

                case "e":
                        txtBoxMain.Text += Math.E.ToString();
                    break;

                case "±":
                    ArgumentOne = double.Parse(txtBoxMain.Text);
                    txtBoxMain.Text = (ArgumentOne * -1).ToString();
                    break;
            }
        }

        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            labelMain.Content = txtBoxMain.Text == "" ? "Вы ничего не ввели" : ArgumentTwo = double.Parse(txtBoxMain.Text);

            switch (Sign)
            {
                case "/":
                    Result = (ArgumentOne / ArgumentTwo);
                    txtBoxMain.Text = Result.ToString("F2");
                    labelMain.Content = $"{ArgumentOne} / {ArgumentTwo} = ";
                    break;
                case "*":
                    Result = (ArgumentOne * ArgumentTwo);
                    txtBoxMain.Text = Result.ToString("F2");
                    labelMain.Content = $"{ArgumentOne} * {ArgumentTwo} = ";
                    break;
                case "-":
                    Result = (ArgumentOne - ArgumentTwo);
                    txtBoxMain.Text = Result.ToString("F2");
                    labelMain.Content = $"{ArgumentOne} - {ArgumentTwo}  = ";
                    break;
                case "+":
                    Result = (ArgumentOne + ArgumentTwo);
                    txtBoxMain.Text = Result.ToString("F2");
                    labelMain.Content = $"{ArgumentOne} + {ArgumentTwo}  = ";
                    break;
                case "^":
                    Result = Math.Pow(ArgumentOne, ArgumentTwo);
                    txtBoxMain.Text = Result.ToString("F2");
                    labelMain.Content = $"{ArgumentOne} ^ {ArgumentTwo}  = ";
                    break;
                //case "n!": // ДОДЕЛАТЬ
                //    //Result = Factorial(ArgumentOne);
                //    txtBoxMain.Text = Result.ToString("F2");
                //    labelMain.Content = $"{ArgumentOne} ^ {ArgumentTwo}  = ";
                //    break;
                case "√":
                    ArgumentTwo = double.Parse(txtBoxMain.Text);
                    if (ArgumentTwo >= 1)
                    {
                        txtBoxMain.Text = (ArgumentOne + ArgumentTwo).ToString();
                        labelMain.Content = $"√({ArgumentOne}) + √({ArgumentTwo}) = ";
                    }
                    else
                    {
                        labelMain.Content = "Число должно быть >0";
                        txtBoxMain.Text = string.Empty;
                    }
                    break;
            }
        }
        public BigInteger Factorial(BigInteger number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
