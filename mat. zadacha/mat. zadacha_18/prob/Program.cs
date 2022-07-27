using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob
{
    class Program
    {
        static double F(double p) //фиксированная функция (по условию задачи), зависящая от введённых переменных
        {
            return Math.Sqrt(1 + p + 2 * (p * p)) * (2 + p) * (2 + p);
        }
        static void Main(string[] args)
        {
            double x, a, b, h, s;
            int n;
            //ввод начальной точки интервала
            Console.WriteLine("Нижний предел интегрирования a =");
            a = int.Parse(Console.ReadLine());
            //ввод конечной точки интервала
            Console.WriteLine("Верхний предел интегрирования b =");
            b = Double.Parse(Console.ReadLine());
            //ввод количества отрезков, на который мы делим интервал
            Console.WriteLine("Количество отрезков(вводим 10 по условию) n = ");
            n = int.Parse(Console.ReadLine());

            h = (b - a) / n; //вычисление шага интервала
            s = 0; x = a + h; //вычисление значений х в каждом отрезке
            while (x < b) //зацикливаем вычисление х и пишем условия заканчивания вычислений
            {
                s = s + 4 * F(x);
                x = x + h;
                s = s + 2 * F(x);
                x = x + h;
            }
            s = h / 3 * (s + F(a) - F(b)); //конечная формула вычисления значения
            Console.WriteLine("Значение интеграла по Симпсону = {0}", s);
            Console.ReadKey();
        }
    }
}