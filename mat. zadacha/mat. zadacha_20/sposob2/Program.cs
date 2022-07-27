using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sposob2
{
    class Maxc
    {
        public int a { get; set; }
        public int b { get; set; }

        public double x { get; set; }
        public double y { get; set; }

        public char i { get; set; }
        public char j { get; set; }

        public void getData()
        {
            Console.WriteLine("Max int: " + Math.Max(a, b));
            Console.WriteLine("Max double: " + Math.Max(x, y));
            Console.WriteLine("Max char: " + Convert.ToChar(Math.Max(i, j)));
        }
    }
    class Rechnie
    {
        static void maxc(int a, int b)
        {
            Console.WriteLine("Max int: " + Math.Max(a, b));
        }
        static void maxc(double a, double b)
        {
            Console.WriteLine("Max double: " + Math.Max(a, b));
        }
        static void maxc(char a, char b)
        {
            Console.WriteLine("Max char: " + Convert.ToChar(Math.Max(a, b)));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            maxc(66, 23);
            maxc(2.8, 0.66);
            maxc('7', '4');
            Console.ReadKey();
        }
    }
}
