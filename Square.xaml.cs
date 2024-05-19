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
    /// Логика взаимодействия для Square.xaml
    /// </summary>
    public partial class Square : Window
    {
        public Square()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double number;
            if (double.TryParse(InputTextBox.Text, out number) && number >= 0)
            {
                double result = Math.Sqrt(number);
                ResultTextBlock.Text = $"Квадратный корень из {number} \n = {result}";
            }
            else
            {
                ResultTextBlock.Text = "Пожалуйста, введите неотрицательное число.";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
