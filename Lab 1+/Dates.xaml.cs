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
    /// Interaction logic for Dates.xaml
    /// </summary>
    public partial class Dates : Window
    {
        public Dates()
        {
            InitializeComponent();

            DateTime Y = DateTime.Today;
            for (int i = 1980; i <= int.Parse(Y.ToString("yyyy")); i++)
            {
                comboBox_year.Items.Add(i);
            }

            int N = 1;
            for (int i = 0; i < 12; i++)
            {
                comboBox_mounth.Items.Add(N);
                N++;
            }

            comboBox_day.IsEnabled = false;
            comboBox_mounth.IsEnabled = false;
        }

        private void comboBox_mounth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_day.IsEnabled = true;
            comboBox_day.Items.Clear();

            switch (comboBox_mounth.SelectedIndex)
            {
                case 0: case 2: case 4: case 6: case 7: case 9: case 11:
                    {
                        int D = 1;
                        for (int i = 0; i < 31; i++)
                        {
                            comboBox_day.Items.Add(D);
                            D++;
                        }
                    }
                    break;
                case 1:
                    {
                        int D = 1;
                        DateTime Y = DateTime.Today;
                        if (int.Parse(comboBox_year.Items[comboBox_year.SelectedIndex].ToString()) % 4 == 0)
                            {
                                for (int j = 0; j < 29; j++)
                                {
                                    comboBox_day.Items.Add(D);
                                    D++;
                                }
                                
                            } else
                        {
                            for (int k = 0; k < 28; k++)
                            {
                                comboBox_day.Items.Add(D);
                                D++;
                            }
                        }                       
                    }
                    break;
                case 3: case 5: case 8: case 10:
                    {
                        int D = 1;
                        for (int i = 0; i < 30; i++)
                        {
                            comboBox_day.Items.Add(D);
                            D++;
                        }
                    }
                    break;
            }
        }

        private void comboBox_day_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBox_day.SelectedIndex != -1)
            {
                int years = DateTime.Today.Year - Convert.ToInt16(comboBox_year.SelectedValue);
                int mounth = DateTime.Today.Month - Convert.ToInt16(comboBox_mounth.SelectedValue);

                if (mounth < 0)
                {
                    years--;
                    mounth += 12;
                }

                int day = DateTime.Today.Day - Convert.ToInt16(comboBox_day.SelectedValue);

                if (mounth == 0 && day < 0)
                {
                    years--;
                    mounth = 11;
                    day += 31;
                } else if (day < 0)
                {
                    mounth--;
                   day += comboBox_day.Items.Count;
                }

                label_time.Content = "Years: " + years + "\nMounth: " + mounth + "\nDay: " + day;
            }    
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Timer win = new Timer();
            win.Show();

            App.Current.Dispatcher.Invoke(() =>
            {
                Dates Dates = App.Current.Windows.OfType<Dates>().FirstOrDefault();
                if (Dates != null)
                {
                    Dates.Close();
                }
            });
        }

        private void comboBox_year_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_mounth.IsEnabled = true;
        }
    }
}
