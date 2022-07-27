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
using System.Data;

namespace _14._09._21_calculator
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in Calculyator.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string vvod = (string)((Button)e.OriginalSource).Content;
            switch (vvod)
            {
                case "CE":
                    {
                        TextBox_Vichislenie.Text = "";
                        break;
                    }
                case "C":
                    {
                        TextBox_Vichislenie.Text = "";
                        break;
                    }
                case "Back":
                    {
                        TextBox_Vichislenie.Text = TextBox_Vichislenie.Text.Remove(TextBox_Vichislenie.Text.Length - 1);
                        break;
                    }
                case "=":
                    {
                        string chislo = new DataTable().Compute(TextBox_Vichislenie.Text, null).ToString();
                        TextBox_Vichislenie.Text = chislo;
                        break;
                    }
                case "1/x":
                    {
                        string chislo = new DataTable().Compute(TextBox_Vichislenie.Text, null).ToString();
                        var OdinX = Convert.ToDouble(chislo);
                        OdinX = Math.Pow(OdinX, -1);
                        chislo = Convert.ToString(OdinX);
                        {
                        TextBox_Vichislenie.Text = chislo;
                        break;}
                    }
                case "x²":
                    {
                        string chislo = new DataTable().Compute(TextBox_Vichislenie.Text, null).ToString();
                        var kvadrat = Convert.ToDouble(chislo);
                        kvadrat = Math.Pow(kvadrat, 2);
                        chislo = Convert.ToString(kvadrat);
                        TextBox_Vichislenie.Text = chislo;
                        break;

                    }     
                case "±":
                    {
                        string chislo = new DataTable().Compute(TextBox_Vichislenie.Text, null).ToString();
                        var plus_minus = Convert.ToDouble(chislo);
                        plus_minus = -plus_minus;
                        chislo = Convert.ToString(plus_minus);
                        TextBox_Vichislenie.Text = chislo;
                        break;
                    }
                case ".":
                    {
                        string chislo = new DataTable().Compute(TextBox_Vichislenie.Text, null).ToString();
                        chislo = TextBox_Vichislenie.Text + '.';
                        TextBox_Vichislenie.Text = chislo;
                        break;
                    }
                case "√":
                    {
                        string chislo = new DataTable().Compute(TextBox_Vichislenie.Text, null).ToString();
                        var koren = Convert.ToDouble(chislo);
                        koren = Math.Sqrt(koren);
                        chislo = Convert.ToString(koren);
                        TextBox_Vichislenie.Text = chislo;
                        break;
                    }
                case "%":
                    {
                        int k = 0;
                        string str = TextBox_Vichislenie.Text;
                        for (int i = str.Length - 1; i >= 0; i--)
                        {

                            if (str[i] == '*' || str[i] == '+' || str[i] == '/' || str[i] == '-')
                            {
                                k++;
                                string proz = str.Remove(0, i + 1);
                                string a = str.Remove(i, str.Length - i);
                                switch (str[i])
                                {
                                    case '+': { TextBox_Vichislenie.Text = "(" + a + ")+(" + a + ")*" + proz + "/100"; 
                                        break; }
                                    case '-': { TextBox_Vichislenie.Text = "(" + a + ")-(" + a + ")*" + proz + "/100"; 
                                        break; }
                                    case '*': { TextBox_Vichislenie.Text = "(" + a + ")*" + proz + "/100"; 
                                        break; }
                                    case '/': { TextBox_Vichislenie.Text = "(" + a + ")/" + proz + "*100"; 
                                        break; }
                                    default: { break; }

                                }

                            }
                            if (k == 1) { break; }
                        }
                        break;
                    }
                default:
                    {
                        TextBox_Vichislenie.Text += vvod;
                        break;
                    }
            }
        }
    }
}
