using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово на англ. алф.");
            string n = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ответ " + chet(n));
            Console.ReadKey();
        }
         static int chet(string n)
            {
            int r = 0;
            int p = 'a';
            for (int i=0;i<n.Length;i++)
            {
                int c = Math.Abs(n[i] - p);
                int a = 26 - c;
                r += Math.Min(a, c);
                p = n[i];
            }
            return r;
            }
        }
    }

