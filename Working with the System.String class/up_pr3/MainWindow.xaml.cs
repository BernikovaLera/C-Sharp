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

namespace up_pr3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // Contain
        {
            string str1 = Convert.ToString(TextBoxstr1.Text);
            string str2 = Convert.ToString(TextBoxstr2.Text);
            int itogovayz_stroka=0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (Convert.ToString(str1[i]).Contains(str2) == true)
                {
                    itogovayz_stroka++;
                }
            }
            TextBoxotvet.Text = Convert.ToString(itogovayz_stroka); 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // Concat
        {
            string str3 = Convert.ToString(TextBoxstr3.Text);
            string str4 = Convert.ToString(TextBoxstr4.Text);
            string itogovayz_stroka;
            itogovayz_stroka = String.Concat(str3, str4);
            TextBoxstr5.Text = Convert.ToString(itogovayz_stroka); 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) // perv_simvl
        {
            string text = Convert.ToString(TextBoxtext.Text);
            string elem = Convert.ToString(TextBoxelem.Text);
            int perv_index;
            perv_index = text.IndexOf(elem);
            TextBlockotvet3.Text = Convert.ToString(perv_index);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) // posl_simvl
        {
            string text = Convert.ToString(TextBoxtext.Text);
            string elem = Convert.ToString(TextBoxelem.Text);
            int posl_index;
            posl_index = text.LastIndexOf(elem);
            TextBlockotvet3.Text = Convert.ToString(posl_index);
        }
    }
}
