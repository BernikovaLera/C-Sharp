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

namespace up_pr2
{
        public partial class MainWindow : Window
        {
            public DataTable Tt(int[,] arr)
            {

                DataTable output = new DataTable();
                for (int i = 0; i < 10; i++)
                {
                    output.Columns.Add(i.ToString());
                }
                for (int i = 0; i < 10; i++)
                {
                    DataRow row = output.NewRow();
                    for (int j = 0; j < 10; j++)
                        row[j.ToString()] = arr[i, j];
                    output.Rows.Add(row);
                }
                grid.DataContext = output.DefaultView;
                return output;
            }

            public int[,] DateNew()
            {
                int[,] arr = new int[10, 10];
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        arr[i, j] = rnd.Next(0, 100);
                return arr;
            }


            public MainWindow()
            {
                InitializeComponent();
            }

            private void Hh(object sender, RoutedEventArgs e)
            {
                int[,] arr = DateNew();
                Tt(arr);


                int sum = 0, min = 100, max = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum += arr[i, i];
                    if (arr[i, i] > max)
                        max = arr[i, i];
                    if (arr[i, i] < min)
                        min = arr[i, i];
                }
                rt1.Content = Convert.ToString(sum);
                rt2.Content = max;
                rt3.Content = min;


                for (int i = 0; i < 10; i++)
                {
                    sum += arr[i, 9 - i];
                    if (arr[i, 9 - i] > max)
                        max = arr[i, 9 - i];
                    if (arr[i, 9 - i] < min)
                        min = arr[i, 9 - i];
                }

                rt4.Content = Convert.ToString(sum);
                rt5.Content = max;
                rt6.Content = min;
                sum = 0;
                min = 100;
                max = 0;

                for (int i = 0; i < 5; i++)
                    for (int j = (0 + i); j < (10 - i); j++)
                    {
                        sum += arr[j, i];
                        if (arr[j, i] > max)
                            max = arr[j, i];
                        if (arr[j, i] < min)
                            min = arr[j, i];
                    }

                rt7.Content = Convert.ToString(sum);
                rt8.Content = max;
                rt9.Content = min;
                sum = 0;
                min = 100;
                max = 0;

                for (int i = 0; i < 5; i++)
                    for (int j = (0 + i); j < (10 - i); j++)
                    {
                        sum += arr[i, j];
                        if (arr[i, j] > max)
                            max = arr[i, j];
                        if (arr[i, j] < min)
                            min = arr[i, j];
                    }

                rt10.Content = Convert.ToString(sum);
                rt11.Content = max;
                rt12.Content = min;
                sum = 0;
                min = 100;
                max = 0;

                for (int i = 5; i < 10; i++)
                    for (int j = 9 - i; j < i + 1; j++)
                    {
                        sum += arr[j, i];
                        if (arr[j, i] > max)
                            max = arr[j, i];
                        if (arr[j, i] < min)
                            min = arr[j, i];
                    }

                rt13.Content = Convert.ToString(sum);
                rt14.Content = max;
                rt15.Content = min;
                sum = 0;
                min = 100;
                max = 0;

                for (int i = 5; i < 10; i++)
                    for (int j = 9 - i; j < i + 1; j++)
                    {
                        sum += arr[i, j];
                        if (arr[i, j] > max)
                            max = arr[i, j];
                        if (arr[i, j] < min)
                            min = arr[i, j];
                    }

                rt16.Content = Convert.ToString(sum);
                rt17.Content = max;
                rt18.Content = min;
            }
        }
    }
