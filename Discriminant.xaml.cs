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
    /// Логика взаимодействия для Discriminant.xaml
    /// </summary>
    public partial class Discriminant : Window
    {
        public Discriminant()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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

        private void watermarkB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(inputA.Text);
            double b = Convert.ToDouble(inputB.Text);
            double c = Convert.ToDouble(inputC.Text);

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                ResultLabel.Content = "Корни отсутствуют";
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                ResultLabel.Content = $"1 корень: {root}";
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                ResultLabel.Content = $"Корень 1: {root1} \n Корень 2: {root2}";
            }
        }

        private void watermarkC_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
