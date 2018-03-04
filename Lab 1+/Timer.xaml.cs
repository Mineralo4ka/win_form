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
    /// Interaction logic for Timer.xaml
    /// </summary>
    public partial class Timer : Window
    {
        int sec = 0, min = 0, hour = 0;
        System.Windows.Threading.DispatcherTimer Stopwatch = new System.Windows.Threading.DispatcherTimer();

        public Timer()
        {
            InitializeComponent();
            Stopwatch.Interval = new TimeSpan(0, 0, 1);
            Stopwatch.Tick += new EventHandler(Timer_Tick);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ++sec;
            if (sec == 60)
            {
                ++min;
                sec = 0;
            }

            if (min == 60)
            {
                ++hour;
                min = 0;
            }

            if (checkBox_seconds.IsChecked == true)
            {
                Result.Content = sec;
            }

            if (checkBox_minutes.IsChecked == true)
            {
                Result.Content = min;
            }

            if (checkBox_hours.IsChecked == true)
            {
                Result.Content = hour;
            }

            if (checkBox_minutes.IsChecked == true && checkBox_seconds.IsChecked == true)
            {
                Result.Content = min + ":" + sec;
            }

            if (checkBox_hours.IsChecked == true && checkBox_seconds.IsChecked == true)
            {
                Result.Content = hour + ":" + sec;
            }

            if (checkBox_hours.IsChecked == true && checkBox_minutes.IsChecked == true)
            {
                Result.Content = hour + ":" + min;
            }

            if (checkBox_hours.IsChecked == true && checkBox_minutes.IsChecked == true && checkBox_seconds.IsChecked == true)
            {
                Result.Content = hour + ":" + min + ":" + sec;
            }
        }

        private void button_start_Click(object sender, RoutedEventArgs e)
        {         
            Stopwatch.Start(); 
        }

        private void button_stop_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch.Stop();
        }

        private void button_reset_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = 0;
            sec = 0;
            min = 0;
            hour = 0;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Menu win = new Menu();
            win.Show();

            App.Current.Dispatcher.Invoke(() =>
            {
                Timer Timer = App.Current.Windows.OfType<Timer>().FirstOrDefault();
                if (Timer != null)
                {
                    Timer.Close();
                }
            });
        }
    }
}
