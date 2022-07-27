using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            Console.WriteLine("Введите размерность системы");
            int n = int.Parse(Console.ReadLine());
            double[,] a = new double[n, n];
            double[] b = new double[n];
            double[] x = new double[n];
            for (int i = 0; i < n; i++)
                x[i] = 0;
            Console.WriteLine("Введите построчно коэффициенты системы");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = double.Parse(Console.ReadLine());
                }
            Console.WriteLine("Введите свободные коэффициенты");
            for (int i = 0; i < n; i++)
                b[i] = double.Parse(Console.ReadLine());

            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    for (int j = k + 1; j < n; j++)
                    {
                        a[i, j] = a[i, j] - a[k, j] * (a[i, k] / a[k, k]);
                    }
                    b[i] = b[i] - b[k] * a[i, k] / a[k, k];
                }
            }
            for (int k = n - 1; k >= 0; k--)
            {
                s = 0;
                for (int j = k + 1; j < n; j++)
                    s = s + a[k, j] * x[j];
                x[k] = (b[k] - s) / a[k, k];
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Система имеет следующие корни");
                Console.WriteLine("x = {0:0.##}", x[i]);
                Console.WriteLine("y = {0:0.##}", x[i]);
                Console.WriteLine("z = {0:0.##}", x[i]);
            }
            Console.ReadKey();
        }
    }
}
