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
using program1.Pages;

namespace program1
{
    /// <summary>
    /// Логика взаимодействия для Teacher.xaml
    /// </summary>
    public partial class Teacher : Window
    {
        StudentPage pST = new StudentPage();
        TeacherPage tST = new TeacherPage();
        public Teacher()
        {
            InitializeComponent();
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

        private void Button_Teacher(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new TeacherPage());
        }

        private void Button_Student(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new StudentPage());
        }
    }
}
