using System.Windows.Controls;

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

        private void Button_Click_Get_Sign(object sender, System.Windows.RoutedEventArgs e)
        {
            Button button = sender as Button;
            txtBoxMain.Text += button.Content.ToString();
        }

        private void Button_ClickCleanLast(object sender, System.Windows.RoutedEventArgs e)
        {
            if (txtBoxMain.Text != "")
            {
                txtBoxMain.Text = txtBoxMain.Text.Remove(txtBoxMain.Text.Length - 1);
            }
        }
    }
}
