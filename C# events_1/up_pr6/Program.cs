using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_pr6
{
    delegate void Del();
    class classEvent 
    {
        public event Del Event;
        public void Del2()
        {Event();}
    }
    class forEvent
    {
        public string ob { set { funEvent = value; } get { return funEvent; } }
        string funEvent;
        public void fun0(string ob)
        {this.ob = ob;}
        public void Obb()
        {
            Console.WriteLine("Лиса поймала петуха " + ob);
            Console.WriteLine("И посадила в клетку" + ob);
            Console.WriteLine(@"""Я откормлю Вас, ха-ха-ха!""" + ob);
            Console.WriteLine(@"""И съем Вас, как конфетку""" + ob);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №6");
            Console.WriteLine("Выполнила: Берникова В. 3ПКС-118\n");
            Console.WriteLine("Программа демонстрирует вызов различных событий.");
            Console.WriteLine("Пусть в пространстве имен EVENT объявлен один делегат Del и два класса:");
            Console.WriteLine("\t* класс classEvent, содержащий событие Event и функцию funEvent для генерирования события;");
            Console.WriteLine("\t* класс - forEvent с функциями, предназначенными для включения различных событий в период исполнения.");
            Console.WriteLine("Формально класс forEvent не связан ни с каким-либо делегатом, ни с событием.");
            Console.WriteLine("Коды по шагам:");
            Console.WriteLine("\t1. Первоначально создается объект ob класса, содержащего событие.");
            Console.WriteLine("\t2. Далее к объекту присоединяется ссылка на делегат для статической функции fun0.");
            Console.WriteLine("\t\tТеперь функция funEvent уже может вызвать событие (в частности функцию fun0).");
            Console.WriteLine("\t\tДо присоединения указателя объект ob ссылался на null.");
            Console.WriteLine("\t3. Для включения в событие нестатистических функций необходимо создать объект соответсвующего класса (obb)");
            Console.WriteLine("\t\tи присоединить ссылки к нужному событию.");
            Console.WriteLine("\t\tВ программе организованы два вызова события:");
            Console.WriteLine("\t* после присоединения только статестических функций и");
            Console.WriteLine("\t* после присоединения всех функций.");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("РЕЗУЛЬТАТ РАБОТЫ:\n");
            Console.WriteLine("Происходит СОБЫТИЕ!");
            classEvent del = new classEvent();
            forEvent del2 = new forEvent();
            del.Event += del2.Obb;
            del.Del2();
            Console.ReadKey();
        }
    }
}
