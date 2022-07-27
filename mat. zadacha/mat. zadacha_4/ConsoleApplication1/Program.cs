using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        public string name;
        public int age;
        public void GetInfo()
        {
            Console.WriteLine("Имя: {name} Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.GetInfo();
            tom.name = "Lera";
            tom.age = 1;
            tom.GetInfo();
            Console.ReadKey();
        }
    }
}
