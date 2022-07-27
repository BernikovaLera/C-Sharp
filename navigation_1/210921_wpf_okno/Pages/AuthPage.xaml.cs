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

namespace _210921_wpf_okno.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Window
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void ButtonEnret_OnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxLogin.Text) | string.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            //using (var db = new Entities())
            //{
            //    var user = db.User1
            //    .AsNoTracking()
            //    .FirstOrDefault(u => u.Login == TextBoxLogin.Text & u.Password == PasswordBox.Password);
            //    if (user == null)
            //    {
            //        MessageBox.Show("Пользователь с такими данными не найден!");
            //        return;
            //    }
            //    MessageBox.Show("Пользователь успешно найден!");
            //}
        }
    }
}
