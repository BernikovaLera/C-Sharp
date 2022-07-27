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
    /// Логика взаимодействия для Window_Konus.xaml
    /// </summary>
    public partial class Window_Konus : Window
    {
        public Window_Konus()
        {
            InitializeComponent();
        }

        private void Chet_Click(object sender, RoutedEventArgs e)
        {
            double R = Convert.ToDouble(TextBoxR.Text);
            double H = Convert.ToDouble(TextBoxH.Text);
            var otvet = ClassRechnie.Konus(R, H);
            TextBlockSo.Text = Convert.ToString(otvet.Item1);
            TextBlockSb.Text = Convert.ToString(otvet.Item2);
            TextBlockSob.Text = Convert.ToString(otvet.Item3);
            TextBlockV.Text = Convert.ToString(otvet.Item4);
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
