using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sposob1
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
    static void Main(string[] args)
    {
        Maxc result = new Maxc();
        Console.WriteLine("Задание 2");
        result.a = 66;
        result.b = 23;
        result.x = 0.66;
        result.y = 3.28;
        result.i = '7';
        result.j = '4';
        result.getData();

        Console.ReadKey();
    }
    }
}

