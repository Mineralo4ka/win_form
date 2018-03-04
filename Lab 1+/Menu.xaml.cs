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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.FileName = "Document";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";

            dlg.ShowDialog();

            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(dlg.FileName);

            while ((line = file.ReadLine()) != null)
            {
                listBox.Items.Add(line);
            }
  
            file.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "Document";
                dlg.DefaultExt = ".txt";
                dlg.Filter = "Text documents (.txt)|*.txt";

                dlg.ShowDialog();

                string line = listBox.Items[listBox.SelectedIndex].ToString();
                System.IO.StreamWriter file = new System.IO.StreamWriter(dlg.FileName);
                file.WriteLine(line);
                file.Close();
            }
            else
            {
                Wrong.Content = "Вы не выбрали элемент";
            }  
        }
    }
}
