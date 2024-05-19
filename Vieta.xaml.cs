using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pp
{
    /// <summary>
    /// Логика взаимодействия для Vieta.xaml
    /// </summary>
    public partial class Vieta : Window
    {
        public Vieta()
        {
            InitializeComponent();
        }

        private void watermarkA_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkA.Visibility = System.Windows.Visibility.Collapsed;
            inputA.Visibility = System.Windows.Visibility.Visible;
            inputA.Focus();
        }

        private void inputA_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(inputA.Text))
            {
                inputA.Visibility = System.Windows.Visibility.Collapsed;
                watermarkA.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void watermarkC_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkC.Visibility = System.Windows.Visibility.Collapsed;
            inputC.Visibility = System.Windows.Visibility.Visible;
            inputC.Focus();
        }

        private void inputC_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(inputC.Text))
            {
                inputC.Visibility = System.Windows.Visibility.Collapsed;
                watermarkC.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void watermarkB_GotFocus(object sender, RoutedEventArgs e)
        {
            watermarkB.Visibility = System.Windows.Visibility.Collapsed;
            inputB.Visibility = System.Windows.Visibility.Visible;
            inputB.Focus();
        }

        private void inputB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(inputB.Text))
            {
                inputB.Visibility = System.Windows.Visibility.Collapsed;
                watermarkB.Visibility = System.Windows.Visibility.Visible;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(inputA.Text);
            double b = Convert.ToDouble(inputB.Text);
            double c = Convert.ToDouble(inputC.Text);

            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

            ResultLabel.Content = $"Корни равны: \n x1 = {x1} \n x2 = {x2}";
        }

        private void textBoxA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void watermarkB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
