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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Drobi_lb(object sender, RoutedEventArgs e)
        {
            DrobiInfo drobiInfo = new DrobiInfo();
            drobiInfo.Show();
            this.Close();
        }

        private void Vieta_lb(object sender, RoutedEventArgs e)
        {
            Vieta vieta = new Vieta();
            vieta.Show();
            this.Close();
        }

        private void Discriminant_lb(object sender, RoutedEventArgs e)
        {
            Discriminant discriminant = new Discriminant();
            discriminant.Show();
            this.Close();
        }

        private void TableSquare_lb(object sender, RoutedEventArgs e)
        {
            TableSquares tableSquares = new TableSquares();
            tableSquares.Show();
            this.Close();
        }

        private void Out(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
