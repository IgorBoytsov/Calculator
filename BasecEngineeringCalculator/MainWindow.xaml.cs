using System.Windows;

namespace BasecEngineeringCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void MenuItem_Click_Calc(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new BasecCalcPage());
        }

        private void MenuItem_Click_EngeneeringCalc(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new EngineeringCalcPage());
        }

        private void MenuItem_ExitApp(object sender, RoutedEventArgs e)
        {
            //if (MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            //{
            //    Close();
            //}
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButton.YesNoCancel, MessageBoxImage.Question) == MessageBoxResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}



