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
    /// Логика взаимодействия для Window_YsKonus.xaml
    /// </summary>
    public partial class Window_YsKonus : Window
    {
        public Window_YsKonus()
        {
            InitializeComponent();
        }
        private void Chet_Click(object sender, RoutedEventArgs e)
        {
            double R1 = Convert.ToDouble(TextBoxR1.Text);
            double R2 = Convert.ToDouble(TextBoxR2.Text);
            double H = Convert.ToDouble(TextBoxH.Text);
            var otvet = ClassRechnie.YsKonus(R1, R2, H);
            TextBlockS1.Text = Convert.ToString(otvet.Item1);
            TextBlockS2.Text = Convert.ToString(otvet.Item2);
            TextBlockSboc.Text = Convert.ToString(otvet.Item3);
            TextBlockV.Text = Convert.ToString(otvet.Item4);
        }
        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}