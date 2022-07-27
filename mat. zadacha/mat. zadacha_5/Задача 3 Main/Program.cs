using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            long num = Convert.ToInt32(Console.ReadLine());
            AllNum(num);
        }
        static void AllNum(long num)
        {
            int s = 0;
            long num2 = num;
            while ((num /= 10) > 0) 
            s++;
            long[] fig = new long[s + 1];
            for (int i = s; i > 0; i--) 
            {
                fig[i] = num2 % 10;
                num2 /= 10;
            }
            for (int i = 0; i < fig.Length; i++)
                Console.WriteLine(fig[i] + " ");
            Console.ReadKey();
        }
    }
}
