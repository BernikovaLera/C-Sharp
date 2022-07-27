using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Person
    {
        public string name;
        public string fam;
        public string log;

    }
    class Program
    {
        static void Main(string[] args)
        {
            int scet=0;
            Console.Write("Количество фамилий: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Person[] mas = new Person[k];
            for (int i = 0; i < k; i++)
            {
                mas[i] = new Person();
                Console.WriteLine("Введите имя");
                mas[i].name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                mas[i].fam = Console.ReadLine();
            }
            mas[0].log = mas[0].fam;
                for (int i = 1; i < k; i++)
                   {
                      for (int j = 0; j < i; j++)
                         {
                             if (mas[i].fam == mas[j].fam)
                                scet++;
                             if (scet > 0)
                             mas[i].log = mas[i].fam + i;
                             else mas[i].log = mas[i].fam;
                         }
                             scet = 0;
                   }
                      for (int i = 0; i < k; i++)
                      Console.WriteLine(mas[i].log);
                      Console.ReadKey();
            }
        }
    }

