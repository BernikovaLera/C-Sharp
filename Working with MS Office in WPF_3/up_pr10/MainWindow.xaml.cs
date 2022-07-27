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
using Exc = Microsoft.Office.Interop;

namespace up_pr10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Pi_Click(object sender, RoutedEventArgs e)
        {
            var XL = new Microsoft.Office.Interop.Excel.Application();
            var PI = XL.WorksheetFunction.Pi();

            TextBlock_Pi.Text = Math.PI.ToString();

            XL.Quit();
        }
    }
}