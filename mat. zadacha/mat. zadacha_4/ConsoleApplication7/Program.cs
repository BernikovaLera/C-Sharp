using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Person
    {
        public string tel1;
        public string tel;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество сотрудников: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Person[] mas = new Person[n];
            for (int i = 0; i < n; i++) {
                mas[i] = new Person();
                Console.WriteLine("Телофон: ");
                mas[i].tel1 = Console.ReadLine();
            }
            for (int i = 0; i < mas.Length; i++){
                mas[i].tel = mas[i].tel1.Split(' ').Last();
                mas[i].tel = mas[i].tel.Substring(7, 2);
            }
            int k = 1;
            double kol = 0;
            int sum = 0;
            for (int i = 0; i < mas.Length; i++){
                if (mas[i].tel != "0") {
                    kol++;
                    if (i == mas.Length - 1){
                        sum += k;
                        Console.WriteLine(mas[i].tel + " Кол-во номеров: " + k);
                    }
                    else {
                        for (int j = i + 1; j < mas.Length; j++){
                            if (mas[i].tel == mas[j].tel){
                                k++;
                                mas[j].tel = "0";
                            }
                        }
                        sum += k;
                        Console.WriteLine(mas[i].tel + " Кол-во номеров: " + k);
                        k = 1;
                    }
                }
            }
            Console.WriteLine("Среднее: " + (double)sum / kol);
            Console.ReadKey(); 
        }
    }
}
