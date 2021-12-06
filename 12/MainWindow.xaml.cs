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
using System.Windows.Threading;

namespace _12
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

        DispatcherTimer _timer;// Описываем таймер

        private void P_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int
            if (int.TryParse(Zn1.Text, out int a) && a > 0 )
            {
                P.Text = Rez.P(a).ToString();
            }
            else MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void S_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int
            if (int.TryParse(Zn1.Text, out int a) && a > 0 )
            {
                S.Text = Rez.S(a).ToString();
            }
            else MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    

        private void Edinica_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int
            if (int.TryParse(Zn2.Text, out int a) && a > 99 )
            {
                Edinica.Text = Rez.Edinica(a).ToString();
            }
            else MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    

        private void Desyatki_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int
            if (int.TryParse(Zn2.Text, out int a) && a > 99 )
            {
                Desyatki.Text = Rez.Desyatki(a).ToString();
            }
            else MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {
            //Добавляем таймер
            _timer = new DispatcherTimer();
            _timer.Tick += Timer_Tick;
            _timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            _timer.IsEnabled = true;
        }

        //Создаем вручную событие таймера
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;//Создание обьекта
            time.Text = d.ToString("HH:mm");//Время
            date.Text = d.ToString("dd.MM.yyyy");//Дата
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Сброс_Click(object sender, RoutedEventArgs e)
        {
            Zn1.Focus();
            Zn2.Focus();
            Zn1.Clear();
            Zn2.Clear();
            P.Clear();
            S.Clear();
            Edinica.Clear();
            Desyatki.Clear();
        }

        private void Инфо_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Калион Екатерина, 12 пр," +
                "\nРеализовать расчет задачи:" +
                "\n1)Дана сторона квадрата a.Найти его площадь и периметр." +
                "\n2)Дано трехзначное число.Вывести вначале его последнюю цифру(единицы), а" +
                "затем — его среднюю цифру(десятки)." , Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Сброс1_Click(object sender, RoutedEventArgs e)
        {
            Zn1.Focus();
            Zn1.Clear();
            P.Clear();
            S.Clear();
        }

        private void Сброс2_Click(object sender, RoutedEventArgs e)
        {
            Zn2.Focus();
            Zn2.Clear();
            Edinica.Clear();
            Desyatki.Clear();
        }

        //Когда изменяем текстбокс, очищает остальные текстбоксы
        private void Zn1_TextChanged(object sender, TextChangedEventArgs e)
        {
            P.Clear();
            S.Clear();
        }

        //Когда изменяем текстбокс, очищает остальные текстбоксы
        private void Zn2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Edinica.Clear();
            Desyatki.Clear();
        }

        //Передает фокус кнопке расчитать, если мы ставим курсор на текстбоксе
        private void Zn1_GotFocus(object sender, RoutedEventArgs e)
        {
            p.IsDefault = true;
        }

       //Передает фокус кнопке расчитать, если мы ставим курсор на текстбоксе
        private void Zn2_GotFocus(object sender, RoutedEventArgs e)
        {
            ПоследняяЦифра.IsDefault = true;
        }
    }
    
}
