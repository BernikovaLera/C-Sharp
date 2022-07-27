using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%2==1) Console.WriteLine((n/2) + " " + (n/2+1));
            else
            {
                if((n/2-1)%2==1) Console.WriteLine((n/2-1) + " " + (n/2+1));
                else Console.WriteLine((n/2-2) + " " + (n/2+2));
            }
            Console.ReadKey();
        }
    }
}
