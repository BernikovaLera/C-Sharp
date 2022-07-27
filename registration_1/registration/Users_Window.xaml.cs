using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;

namespace registration
{
    /// <summary>
    /// Логика взаимодействия для Users_Window.xaml
    /// </summary>
    public partial class Users_Window : Window, INotifyPropertyChanged
    {
        public Users_Window()
        {
            InitializeComponent();
            DataContext = this;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private List<Registr> allusers;
        public List<Registr> AllUsers
        {
            get
            {
                return allusers;
            }
            set
            {
                allusers = value;
                PropertyChanged(this, new PropertyChangedEventArgs("AllUsers"));
            }
        }

        private void Users_Loaded(object sender, RoutedEventArgs e)
        {
            //var users = UsersGrid.SelectedItem as Users;
            AllUsers = Core.db.Registr.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var us = UsersGrid.SelectedItem as Registr;

            Core.db.Registr.Remove(us);
            Core.db.SaveChanges();
            MessageBox.Show("Пользователь" + us.surname + "удален");
        }

        //private void Edit_Click(object sender, RoutedEventArgs e)
        //{
        //    var user = UsersGrid.SelectedItem as Registr;
        //    Edit_Window edit_Window = new Edit_Window(user);
        //    edit_Window.ShowDialog();
        //}
    }
}
