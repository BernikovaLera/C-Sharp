using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_pr5
{
    class First
    {
        public static string str { get; set; }
        public static void fun1()
        {
            Console.WriteLine("Берникова 3ПКС-118");
            Console.WriteLine("Практическая работа №5\n");

            Console.WriteLine("В простанстве имен Му создаются 2 класса - First и Second.");
            Console.WriteLine("В классе First");
            Console.WriteLine("\t 1. создается закрытое поле str. Показан пример передачи значения закрытому полю.");
            Console.WriteLine("\t 2. создаются 5 функций для их дальнейшей привязки к делегату.");

            Console.WriteLine("В классе Second");
            Console.WriteLine("\t 1. рассмотрены различные способы добавления методов в делегат.\n");
            str = "###########1";
            Console.WriteLine("Работает fun1:");
        }
        public static void fun2()
        {
            str = "************2";
            Console.WriteLine("Работает fun2:");
        }
        public static void fun3()
        {
            str = "*************23";
            Console.WriteLine("Работает fun3:");
        }
    }
    class Second
    {
        public static void fun4()
        {
            Console.WriteLine("Работает статестическая функция");
            Console.WriteLine("\n");
            First.str = "~~~~~~~~~~~~~~~4";
            Console.WriteLine("Работает fun5 класса Second:");
        }
        public static void fun5()
        {
            First.str = "~~~~~~~~~~~~~~~51";
            Console.WriteLine("Работает fun6:");
        }
    }
    class Rechenie
    {
        delegate void Report();
        static void Main(string[] args)
        {
            Report del;
            del = First.fun1;
            del += ReportD;
            del();
            del = First.fun2;
            del += ReportD;
            del();
            del = First.fun3;
            del += ReportD;
            del();
            del = Second.fun4;
            del += ReportD;
            del();
            del = Second.fun5;
            del += ReportD;
            del();
            Console.ReadKey();
        }
        public static void ReportD()
        {
            Console.WriteLine("Работает функция Report. Значение str: " + First.str);
        }
    }
}