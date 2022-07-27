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
            string s1="Петр";
            string s2="Петров";
            string s3 = "Петрович";
            string s4 = s1 + " " + s2 + " " + s3;
            Console.WriteLine(s4);
            Console.ReadKey();
        }
    }
}
