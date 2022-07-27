using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кол-во домов: ");
            int houses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кол-во Задач: ");
            int tasks = Convert.ToInt32(Console.ReadLine());
            int location = 1;
            long ansTime = 0;
            Console.WriteLine("Дела в доме: ");
            for (int i = 0; i < tasks; ++i )
            {
                int currentTask = Convert.ToInt32(Console.ReadLine());
                if (currentTask >= location)
                    ansTime += currentTask - location;
                else
                    ansTime += houses - (location - currentTask);

                location = currentTask;
            }
            Console.WriteLine("Время потраченное для решения всех дел: "+ansTime);
            Console.ReadKey();
        }
    }
}