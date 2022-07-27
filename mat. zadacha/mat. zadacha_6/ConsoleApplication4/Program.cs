using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 0;
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(Fiba(i));
                    y+=Fiba(i);
            }
            Console.WriteLine("Ответ= " + Fiba(x));
            Console.ReadKey();
        }
        static int Fiba(int x) 
        {
           if (x==0)
           {
               return 0;
           }
            if (x==1)
            {
                return 1;
            }
            return Fiba(x - 1) + Fiba(x - 2);
        }
    }
}
