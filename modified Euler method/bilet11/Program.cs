using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решить задачу Коши для дифференциального уравнения y'=y-3x");  
            Console.WriteLine("на отрезке [1;2.2] при заданном начальном условии y(1)=0 и h=0.3");
            Console.WriteLine("модифицированным методом Эйлера на языке программирования C#");
            Console.WriteLine("\nБерникова Валерия 3ПКС-118 Билет№11\n");
            double Metod = EulerMetod();  
            Console.ReadKey();
        }
        static double EulerMetod()
        {
            int a = 1;
            double b = 2.2;
            double h = 0.3;
            int n = (int)((b - a) / h) + 1;
            double[] x = new double[n];
            double[] y = new double[n];
            x[0] = 1;
            y[0] = 0;
            for (int i = 1; i<n; i++)
            {
                double fx = f((x[i - 1] + h / 2), y[i - 1] + h / 2 * f(x[i - 1], y[i - 1])) * h;
                x[i] = a + i * h;
                y[i] = y[i - 1] + fx;
            }
            double reshnie = y[n - 1];
            Console.WriteLine("Модифицированный метод Эйлера");
            Console.WriteLine("x \t y");
            for(int i = 0; i<n;i++)
            {
                Console.WriteLine("{0} \t {1}", Math.Round(x[i], 3), Math.Round(y[i], 5));
            }
            return reshnie;
        }
        static double f(double x, double y)
        {
            return y - 3 * x;
        }
    }
}
