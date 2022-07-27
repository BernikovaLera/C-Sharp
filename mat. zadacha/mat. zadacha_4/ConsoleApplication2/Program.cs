using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Person
    {
        public string name;
        public string sername;
        public int a;
        public int b;
        public int c;
        public int GetS()
        {
            return a + b + c;
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
                Console.WriteLine("Введите имя");
                mas[i].name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                mas[i].sername = Console.ReadLine();
                Console.WriteLine("Баллы");
                mas[i].a = Convert.ToInt32(Console.ReadLine());
                mas[i].b = Convert.ToInt32(Console.ReadLine());
                mas[i].c = Convert.ToInt32(Console.ReadLine());
            }
            int max = 1;
            for (int i = 1; i < 3; i++)
            {
                if (mas[i].GetS()>mas[max].GetS())
                {
                    max = i;
                }
            }
            Console.WriteLine(mas[max].name + ' ' + mas[max].sername);
            Console.ReadKey();
        }
    }
}
