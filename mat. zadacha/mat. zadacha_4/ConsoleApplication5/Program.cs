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
            //string fam="";
            //string name="";
            //int n;
            //Console.WriteLine(n); //кол-во строк
            //for (int i = 0; i < n; i++) 
            //{
            //    Console.WriteLine("Фамилия" + fam);
            //    Console.WriteLine("Имя" + name);
            //}
            string s = Console.ReadLine();
            string[] a = s.Split(new char[] { ' ' }, StringSplitOptoons.RemoveEmptyEntries);
            Console.WriteLine("Фамилия" + a[0]);
            Console.WriteLine("Имя" + a[1]);
            Console.ReadKey();
        }
    }
}
