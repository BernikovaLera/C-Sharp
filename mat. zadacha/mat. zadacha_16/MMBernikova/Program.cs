using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MMBernikova
{
    class Tops
    {
        public string Name { get; set; }
        public int[] road { get; set; }
        public string path { get; set; }
        public int pathlenght { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь графа через пробел: ");
            string[] names = Console.ReadLine().Split(' ');
            Console.WriteLine("Введите матрицу:");
            string[] roads = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
                roads[i] = Console.ReadLine();
            String[] roadoftop;
            Tops[] graf = new Tops[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                graf[i] = new Tops();
                roadoftop = roads[i].Split(' ');
                graf[i].road = new int[roadoftop.Length];
                graf[i].pathlenght = 0;
                graf[i].Name = names[i];

                for (int j = 0; j < roadoftop.Length; j++)
                {
                    graf[i].road[j] = Convert.ToInt32(roadoftop[j]);
                }
                graf[i].path = graf[i].Name;
            }
            for (int j = 0; j < graf[0].road.Length; j++)
            {
                for (int i = 0; i < graf[0].road.Length; i++)
                {
                    if (graf[j].road[i] != 0)
                        if (graf[i].pathlenght == 0 ||
                            graf[i].pathlenght > graf[j].pathlenght + graf[j].road[i])
                        {
                            graf[i].pathlenght = graf[j].pathlenght + graf[j].road[i];
                            graf[i].path = graf[j].path + '-' + graf[i].Name;
                        }

                }
            }
            Console.WriteLine("путь: " + graf[graf.Length - 1].path);
            Console.WriteLine("длина: " + graf[graf.Length - 1].pathlenght);
            Console.WriteLine("Кратчайший путь");

            for (int j = 0; j < graf[0].road.Length; j++)
            {
                for (int i = 0; i < graf[0].road.Length; i++)
                {
                    if (graf[j].road[i] != 0)
                        if (graf[i].pathlenght == 0 ||
                            graf[i].pathlenght < graf[j].pathlenght + graf[j].road[i])
                        {
                            graf[i].pathlenght = graf[j].pathlenght + graf[j].road[i];
                            graf[i].path = graf[j].path + '-' + graf[i].Name;
                        }
                }
            }
            Console.WriteLine("путь: " + graf[graf.Length - 1].path);
            Console.WriteLine("длина: " + graf[graf.Length - 1].pathlenght);
            Console.WriteLine("Критический путь");
            Console.ReadKey();
        }
    }
}
