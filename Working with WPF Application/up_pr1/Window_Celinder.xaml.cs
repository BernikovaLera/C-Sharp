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
    /// Логика взаимодействия для Window_Celinder.xaml
    /// </summary>
    public partial class Window_Celinder : Window
    {
        public Window_Celinder()
        {
            InitializeComponent();
        }

        private void Chet_Click(object sender, RoutedEventArgs e)
        {
            double R = Convert.ToDouble(TextBoxR1.Text);
            double H = Convert.ToDouble(TextBoxH.Text);
            var otvet = ClassRechnie.Celinder(R, H);
            TextBlockSocn.Text = Convert.ToString(otvet.Item1);
            TextBlockSboc.Text = Convert.ToString(otvet.Item2);
            TextBlockSob.Text = Convert.ToString(otvet.Item3);
            TextBlockV.Text = Convert.ToString(otvet.Item4);
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
