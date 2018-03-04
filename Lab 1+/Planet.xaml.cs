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
    /// Interaction logic for Planet.xaml
    /// </summary>
    public partial class Planet : Window
    {
        public Planet()
        {
            InitializeComponent();
            listBox.Items.Add("1. Меркурий");
            listBox.Items.Add("2. Венера");
            listBox.Items.Add("3. Земля");
            listBox.Items.Add("4. Марс");
            listBox.Items.Add("5. Юпитер");
            listBox.Items.Add("6. Сатурн");
            listBox.Items.Add("7. Уран");
            listBox.Items.Add("8. Нептун");
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (listBox.SelectedIndex)
            {
                case 0:
                    {
                        description.Content = "Ближайшая к Солнцу планета\nСолнечной системы. Планета названа в честь\nдревнеримского бога торговли - быстрого \nМеркурия, поскольку она движется по небесной\nсфере быстрее других планет.";
                    }
                break;
                case 1:
                    {
                        description.Content = "Вторая планета Солнечной системы.\nНазвана в честь древнеримской богини любви\nВенеры. Венерианский год составляет 224,7\nземных суток. Она имеет самый длинный период\nвращения вокруг своей оси среди всех планет\nСолнечной системы и вращается в направлении.";
                    }
                break;
                case 2:
                    {
                        description.Content = "Третья от Солнца планета. Пятая по размеру\nсреди всех планет Солнечной системы. Она явля-\nется также крупнейшей по диаметру, массе и\nплотности среди планет земной группы.";
                    }
                break;
                case 3:
                    {
                        description.Content = "Четвёртая по удалённости от Солнца и седьмая\nпо размерам планета Солнечной системы; масса\nпланеты составляет 10,7% массы Земли. Названа\nв честь Марса - древнеримского бога войны,\nсоответствующего древнегреческому Аресу.";
                    }
                break;
                case 4:
                    {
                        description.Content = "Пятая планета от Солнца, крупнейшая в Солнеч-\nной системе. Наряду с Сатурном, Ураном и Нептуном\nЮпитер классифицируется как газовый гигант.";
                    }
                break;
                case 5:
                    {
                        description.Content = "Шестая планета от Солнца и вторая по размерам\nпланета в Солнечной системе после Юпитера.\nСатурн, а также Юпитер, Уран и Нептун, классифи-\nцируются как газовые гиганты. Сатурн назван в\nчесть римского бога земледелия.";
                    }
                break;
                case 6:
                    {
                        description.Content = "Планета Солнечной системы, седьмая по удалён-\nности от Солнца, третья по диаметру и четвёртая\nпо массе. Была открыта в 1781 году\nанглийским астрономом Уильямом Гершелем и\nназвана в честь греческого бога неба Урана.";
                    }
                break;
                case 7:
                    {
                        description.Content = "Восьмая планета Солнечной системы. Нептун так-\nже является четвёртой по\nдиаметру и третьей по массе планетой. Масса\nНептуна в 17,2 раза, а диаметр экватора в 3,9 раза\nбольше земных.";
                    }
                break;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Dates win = new Dates();
            win.Show();

            App.Current.Dispatcher.Invoke(() =>
            {
                Planet Planet = App.Current.Windows.OfType<Planet>().FirstOrDefault();
                if (Planet != null)
                {
                    Planet.Close();
                }
            });
        }
    }
}
