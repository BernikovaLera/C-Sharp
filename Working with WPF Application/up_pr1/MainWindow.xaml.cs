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

namespace up_pr1
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

        private void Sfera_Click(object sender, RoutedEventArgs e)
        {
            Window_Sfera window2 = new Window_Sfera();
            window2.ShowDialog();
        }

        private void Konus_Click(object sender, RoutedEventArgs e)
        {
            Window_Konus window3 = new Window_Konus();
            window3.ShowDialog();
        }
        private void Celinder_Click(object sender, RoutedEventArgs e)
        {
            Window_Celinder window4 = new Window_Celinder();
            window4.ShowDialog();
        }
        private void YsKonus_Click(object sender, RoutedEventArgs e) 
        {
            Window_YsKonus window5 = new Window_YsKonus();
            window5.ShowDialog();
        }

        private void Exet_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
