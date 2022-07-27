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
using _210921_wpf_okno.Pages;

namespace _210921_wpf_okno
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentPage pST = new StudentPage();
        TeacherPage tST = new TeacherPage();
        GroupPage gST = new GroupPage();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new StudentPage());
        }

        private void ForwarButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoForward)
            {
                MyFrame.GoForward();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new TeacherPage());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new GroupPage());
        }
    }
}
