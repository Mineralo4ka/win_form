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

namespace Lab_1_
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Window
    {
        public List()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add(textBox.GetLineText(0));
            textBox.Clear();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Planet win = new Planet();
            win.Show();

            App.Current.Dispatcher.Invoke(() =>
            {
                List List = App.Current.Windows.OfType<List>().FirstOrDefault();
                if (List != null)
                {
                    List.Close();
                }
            });
        }
    }
}
