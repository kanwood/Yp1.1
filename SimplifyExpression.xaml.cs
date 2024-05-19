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
    /// Логика взаимодействия для SimplifyExpression.xaml
    /// </summary>
    public partial class SimplifyExpression : Window
    {
        public SimplifyExpression()
        {
            InitializeComponent();
        }

        private void Simplify_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string expression = txtExpression.Text;
                // Simplify the expression here
                string simplifiedExpression = expression; // Placeholder, replace with actual simplification logic
                txtResult.Text = simplifiedExpression;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtExpression.Text = "";
            txtResult.Text = "";
        }

        private void txtExpression_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
