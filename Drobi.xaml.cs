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
    /// Логика взаимодействия для Drobi.xaml
    /// </summary>
    public partial class Drobi : Window
    {
        public Drobi()
        {
            InitializeComponent();
        }

        private void PlusFractions(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(num1Box.Text);
            int denom1 = int.Parse(denom1Box.Text);

            int num2 = int.Parse(num2Box.Text);
            int denom2 = int.Parse(denom2Box.Text);

            int resultNum = num1 * denom2 + num2 * denom1;
            int resultDenom = denom1 * denom2;

            resultLabel.Content = resultNum + "\n" + "\n" + resultDenom;
        }

        private void MinusFractions(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(num1Box.Text);
            int denom1 = int.Parse(denom1Box.Text);

            int num2 = int.Parse(num2Box.Text);
            int denom2 = int.Parse(denom2Box.Text);

            int resultNum1 = num1 * denom2 - num2 * denom1;
            int resultDenom1 = denom1 * denom2;

            resultLabel.Content = resultNum1 + "\n " + "\n" + resultDenom1;
        }

        private void MultFractions(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(num1Box.Text);
            int denom1 = int.Parse(denom1Box.Text);

            int num2 = int.Parse(num2Box.Text);
            int denom2 = int.Parse(denom2Box.Text);

            int resultNum2 = num1 * num2;
            int resultDenom2 = denom1 * denom2;

            resultLabel.Content = resultNum2 + "\n " + "\n" + resultDenom2;
        }

        private void DelFractions(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(num1Box.Text);
            int denom1 = int.Parse(denom1Box.Text);

            int num2 = int.Parse(num2Box.Text);
            int denom2 = int.Parse(denom2Box.Text);

            int resultNum3 = num1 * denom2;
            int resultDenom3 = denom1 * num2;

            resultLabel.Content =  resultNum3 + "\n " + "\n" + resultDenom3;
        }

        private void num1Box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void denom1Box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void num2Box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void denom2Box_TextChanged(object sender, TextChangedEventArgs e)
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