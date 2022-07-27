using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Зармерность массива ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввод чисел массива ");
            int[] mas = new int[n];
            for (int i = 0; i < mas.Length; ++i)
            mas[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ответ " + scht(mas));
            Console.ReadKey();
        }
        static int scht(int[] mas)
        {
            int s=1;
            for (int i = 0; i < mas.Length-1; ++i)
            {
                if (mas[i] != mas[i+1])
                {
                    s++;
                }
            }
            return s;
        }
        }
    }
