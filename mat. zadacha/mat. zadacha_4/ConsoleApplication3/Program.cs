using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Person
    {
        public string mag;
        public string strit;
        public int a; //жирность 
        public int b; //цена
        public int GetS()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] mas = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                mas[i] = new Person();
                Console.WriteLine("Магазин: ");
                mas[i].mag = Console.ReadLine();
                Console.WriteLine("Улица: ");
                mas[i].strit = Console.ReadLine();
                Console.WriteLine("Жирность(15,20,25%): ");
                mas[i].a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Цена: ");
                mas[i].b = Convert.ToInt32(Console.ReadLine());

            }
            int[] j={15,20,25};
            int min = ;
            for (int i = 1; i < 3; i++)
            {
                if ()
                {
                    ;
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
