using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ответ= " + Func(n));
            Console.ReadKey();
        }
        static int Func(int n) // рекурсия 
        {
            if (n==0)  // ограничение F(0)
            {
                return 0;
            }
            return Convert.ToInt32(Math.Pow(-1, n)) * n + Func(n - 1);
        }
    }
}
