using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Person
    {
        public string part;
        public int count;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество избератилей: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Person[] mas = new Person[k];
            for (int i = 0; i < k; i++)
            {
                mas[i]=new Person();
            }
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine("Введите название партии");
                    string s = Console.ReadLine();
                    int h = 0;

                    while (mas[h].part != s && h < mas.Length && mas[h].part != null)
                    {

                        h++;

                    }

                    mas[h].part = s;
                    mas[h].count++;
                }
                for (int p = k; p > -1; p--)
                {
                    int t = 0;

                    for (t = 0; t < mas.Length;t++ )
                    {
                        if(mas[t].count==p && mas[t].count!=0)
                        {
                            Console.WriteLine(mas[t].part + " " + mas[t].count + "\n");

                        }
                    }
                        
                }
            Console.Read();
        }
    }
}
