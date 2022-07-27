using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            long n, a;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 != 0)
                    a++;
                Console.WriteLine("Ответ "+((a-1)/2));
            }
            Console.ReadKey();
        }
    } 
}