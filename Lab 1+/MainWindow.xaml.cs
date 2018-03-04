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

namespace Lab_1_
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

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            double tx_A, tx_B;
            tx_A = double.Parse(textBox_a.GetLineText(0));
            tx_B = double.Parse(textBox_b.GetLineText(0));

            Result.Content = tx_A + tx_B;
        }

        private void button_minus_Click(object sender, RoutedEventArgs e)
        {
            double tx_A, tx_B;
            tx_A = double.Parse(textBox_a.GetLineText(0));
            tx_B = double.Parse(textBox_b.GetLineText(0));

            Result.Content = tx_A - tx_B;
        }

        private void button_division_Click(object sender, RoutedEventArgs e)
        {
            double tx_A, tx_B;
            tx_A = double.Parse(textBox_a.GetLineText(0));
            tx_B = double.Parse(textBox_b.GetLineText(0));

            Result.Content = tx_A / tx_B;
        }

        private void button_multiplication_Click(object sender, RoutedEventArgs e)
        {
            double tx_A, tx_B;
            tx_A = double.Parse(textBox_a.GetLineText(0));
            tx_B = double.Parse(textBox_b.GetLineText(0));

            Result.Content = tx_A * tx_B;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List win = new List();
            win.Show();

            App.Current.MainWindow.Close();
        }
    }
}
