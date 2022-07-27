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


namespace program1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
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
                using (var db = new Entities())
         {
            var user = db.Table_1
            .AsNoTracking()
            .FirstOrDefault(u=>u. Login == TextBoxLogin.Text & u.Password==PasswordBox.Password);
        if (user == null)
        {
        MessageBox.Show("Пользователь с такими данными не найден!");
        return;
        }
        MessageBox.Show("Пользователь успешно найден!");
             switch (user.Login)
                 {
                 case "Student":
                     MessageBox.Show("Вы успешно вошли как студент!");
                     Student window1 = new Student();
                     window1.Show();
                     break;
                 case "Teachr":
                     MessageBox.Show("Вы успешно вошли как учитель!");
                     Teacher window2 = new Teacher();
                     window2.Show();
                     break;
                 }
        }
        }
    }
}
