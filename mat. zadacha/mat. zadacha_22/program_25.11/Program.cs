using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_25._11
{
    class Program
    {
        static void Swap<T>(ref T a1, ref T a2, ref T a3)
        {
            T a4 = a1; a1 = a2; a2 = a3; a3 = a4;
        }
        static public void Main(string[] args)
        {
            int a1 = 2;
            int a2 = 6;
            int a3 = 4;

            double b1 = 4.5;
            double b2 = 2.9;
            double b3 = 7.3;

            char c1 = 'a';
            char c2 = 'b';
            char c3 = 'c';

            Console.WriteLine("{0}:{1}:{2} | {3}:{4}:{5}  | {6}:{7}:{8} ", a1, a2, a3, b1, b2, b3, c1, c2, c3);
            Swap(ref a1, ref a2, ref a3);
            Swap(ref b1, ref b2, ref b3);
            Swap(ref c1, ref c2, ref c3);
            Console.WriteLine("{0}:{1}:{2} | {3}:{4}:{5}  | {6}:{7}:{8} ", a1, a2, a3, b1, b2, b3, c1, c2, c3);
            Console.ReadKey();
        }
    }
}
