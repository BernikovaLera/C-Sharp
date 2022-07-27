using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        public static double Funk(double x)
        {
            return Math.Exp(-2*x)-2*x+1;
        }
        public static void Pol_Mathod()
        {
            Console.WriteLine("f(x)=e^(-2*x)-2*x+1");
            Console.WriteLine("Границы (0,1)");
            double a = 0;
            double b = 1;
            double x = (a + b) / 2;
            int k = 0;
            while (Math.Abs(b - a) >= 2 * 0.001)
            {
                x = Math.Round((a + b) / 2, 4);
                k++;
                if (Funk(x) > 0 && Funk(a) < 0) { b = x; }
                else if (Funk(x) > 0 && Funk(b) < 0) { a = x; }
                else if (Funk(x) < 0 && Funk(a) > 0) { b = x; }
                else if (Funk(x) < 0 && Funk(b) > 0) { a = x; }

            }
            Console.WriteLine("Ответ: " + x);
            Console.WriteLine("Кол-во " + k);
        }
        public static void Main()
        {
            Console.WriteLine("Половинчатый метод");
            Pol_Mathod();
            Console.ReadKey();
        }
    }
}