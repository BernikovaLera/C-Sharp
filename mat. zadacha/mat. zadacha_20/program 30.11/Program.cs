using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_30._11
{
    class Oboi
    {
        public string material { get; set; }
        public int dlina { get; set; }
        public int size_w { get; set; }
        public int price { get; set; }
        public void getData()
        {
            Console.WriteLine("Материал: " + material);
            Console.WriteLine("Длина: " + dlina);
            Console.WriteLine("Размер: " + size_w);
            Console.WriteLine("Цена: " + price);
        }
    }
    class Rechnie
    {
        static void Main(string[] args)
        {
            Oboi vinilov = new Oboi();
            vinilov.material = "Виниловые обои";
            vinilov.dlina = 500;
            vinilov.size_w = 100;
            vinilov.price = 1000;
            vinilov.getData();

            Oboi bumaga = new Oboi();
            bumaga.material = "Бумажные обои";
            bumaga.dlina = 500;
            bumaga.size_w = 100;
            bumaga.price = 800;
            bumaga.getData();

            Console.ReadKey();
        }
    }
}