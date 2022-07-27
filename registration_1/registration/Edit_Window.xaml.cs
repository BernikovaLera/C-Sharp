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

namespace registration
{
    /// <summary>
    /// Логика взаимодействия для Edit_Window.xaml
    /// </summary>
    public partial class Edit_Window : Window
    {
        public Edit_Window(Registr users)
        {
            InitializeComponent();
            DataContext = this;
            u = users;
        }

        public Registr u { get; set; }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Core.db.SaveChanges();
        }
    }
}
