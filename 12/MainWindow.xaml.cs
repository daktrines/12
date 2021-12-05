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
        

        private void P_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int
            if (int.TryParse(Zn1.Text, out int a) && a > 0 )
            {
                int rez;
                Rez.P(a, out rez);
                P.Text = Convert.ToString(rez);
            }
            else MessageBox.Show("Неверные данные!", "Ошибка");
        }

        private void S_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int
            if (int.TryParse(Zn1.Text, out int a) && a > 0 )
            {
                int rez;
                Rez.S(a, out rez);
                S.Text = Convert.ToString(rez);
            }
            else MessageBox.Show("Неверные данные!", "Ошибка");
        }
    

        private void Edinica_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int
            if (int.TryParse(Zn2.Text, out int a) && a > 99 && a < 1000)
            {
                int rez;
                Rez.Edinica(a, out rez);
                Edinica.Text = Convert.ToString(rez);
            }
            else MessageBox.Show("Неверные данные!", "Ошибка");
        }
    

        private void Desyatki_Click(object sender, RoutedEventArgs e)
        {
            //преобразования string в int
            if (int.TryParse(Zn2.Text, out int a) && a > 99 && a < 1000 )
            {
                int rez;
                Rez.Desyatki(a, out rez);
                Desyatki.Text = Convert.ToString(rez);
            }
            else MessageBox.Show("Неверные данные!", "Ошибка");
        }
    }
    
}
