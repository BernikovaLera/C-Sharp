using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._12._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X: ");
            int x; //Переменная
            x = Convert.ToInt32(Console.ReadLine());

            int n; //нижний предел
            n = 0;

            Console.WriteLine("Введите K: "); //Верхний предел.
            int k;
            k = Convert.ToInt32(Console.ReadLine());
            double znam;
            double step;
            double drob;
            drob = 0; 
            if (x > 1 && k > 1)
            {

                for (int i = 0; i <= k; i++, n++) 
                {
                    step = 2 * n + 1; 
                    znam = (2 * n + 1) * Math.Pow(x, step); 
                    drob = drob + 1 / znam; 
                }
            }
            else
            {
                Console.WriteLine("Неправильно ввели значение, попробуйте еще раз"); 
            }

            Console.WriteLine(drob); 
            Console.ReadLine();

            Console.WriteLine("Введите Z, в промежутке от -1 до 1"); 
            double z;
            z = Convert.ToDouble(Console.ReadLine()); 
            double ln;

            double rez;
            rez = 0;


            if (z < 1 && z > -1) // проверяется условие на -1 и 1.
            {
                ln = Math.Log((1 + z) / (1 - z)); 
                rez = 0.5 * ln; 
            }
            else
            {
                Console.WriteLine("Вы неправильно ввели Z, попробуйте еще раз");
            }

            Console.WriteLine(rez); 
            Console.ReadLine();
        }
    }


}
