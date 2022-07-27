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

namespace up_pr1
{
    /// <summary>
    /// Логика взаимодействия для Window_Sfera.xaml
    /// </summary>
    public partial class Window_Sfera : Window
    {
        public Window_Sfera()
        {
            InitializeComponent();
        }

        private void Chet_Click(object sender, RoutedEventArgs e)
        {
            double R = Convert.ToDouble(TextBoxR.Text);
            var otvet = ClassRechnie.Sfera(R);
            TextBlockV.Text = Convert.ToString(otvet.Item1);
            TextBlockS.Text = Convert.ToString(otvet.Item2);
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
