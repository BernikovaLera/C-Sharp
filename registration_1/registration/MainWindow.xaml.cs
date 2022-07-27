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

namespace registration
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Registr users = new Registr();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            users.name = name.Text;
            users.surname = surname.Text;
            users.patronymic = patroniymic.Text;

            Core.db.Registr.Add(users);
            Core.db.SaveChanges();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Users_Window users_Window = new Users_Window();
            users_Window.ShowDialog();
        }
    }
}
