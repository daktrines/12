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
            int rez;
            int a = Convert.ToInt32(Zn1.Text);
            Rez.P(a, out rez);
            P.Text = Convert.ToString(rez);
        }

        private void S_Click(object sender, RoutedEventArgs e)
        {
            int rez;
            int a = Convert.ToInt32(Zn1.Text);
            Rez.S(a, out rez);
            S.Text = Convert.ToString(rez);
        }

        private void Edinica_Click(object sender, RoutedEventArgs e)
        {
            int rez;
            int a = Convert.ToInt32(Zn2.Text);
            Rez.Edinica(a, out rez);
            Edinica.Text = Convert.ToString(rez);
        }

        private void Desyatki_Click(object sender, RoutedEventArgs e)
        {
            int rez;
            int a = Convert.ToInt32(Zn2.Text);
            Rez.Desyatki(a, out rez);
            Desyatki.Text = Convert.ToString(rez);
        }
    }
}
