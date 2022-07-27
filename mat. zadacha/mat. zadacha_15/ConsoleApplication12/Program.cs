using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static bool Proverka(double[,] mas, int m, int n)
        {
            for (int j = 0; j < n; j++)
            {
                if (mas[m - 1, j] > 0) { return false; }
            }
            return true;
        }
        static void Obr()
        {
        }
        static void Main(string[] args)
        {
            int m = 4;
            int n = 6;
            double[,] mas = new double[m, n];
            Console.Write("Берникова Валерия пкс-118\n");
            Console.Write("Практическая работа №5\n");
            Console.Write("Вариант 2\n");
            Console.Write("Введите количество корней: ");
            int kolvokor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string EnterString = Console.ReadLine();
                string[] masString = EnterString.Split(new Char[] { ' ' });
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = int.Parse(masString[j]);
                }
            }
            while (Proverka(mas, m, n) == false)
            {
                //выбор ведущего элемента
                int MainElStroka = 0;
                int MainElStolbets = 0;
                int StrokaVedEl = 0;
                int StolbetsVedEl = 0;
                double minvStolbets;
                double maxStolbets = 0;
                for (int j = 0; j < n - 1; j++)
                {
                    minvStolbets = 0;
                    for (int i = 0; i < m - 1; i++)
                    {
                        if (mas[i, j] > 0 && mas[m - 1, j] > 0 && minvStolbets == 0)
                        {
                            minvStolbets = mas[i, n - 1] / mas[i, j] * mas[m - 1, j];
                            MainElStroka = i;
                            MainElStolbets = j;
                        }
                        else
                        {
                            if (mas[i, j] > 0 && mas[m - 1, j] > 0 && mas[i, n - 1] / mas[i, j] * mas[m - 1, j] < minvStolbets)
                            {
                                minvStolbets = mas[i, n - 1] / mas[i, j] * mas[m - 1, j];
                                MainElStroka = i;
                                MainElStolbets = j;
                            }
                        }
                    }
                    if (maxStolbets < minvStolbets)
                    {
                        maxStolbets = minvStolbets;
                        StrokaVedEl = MainElStroka;
                        StolbetsVedEl = MainElStolbets;
                    }
                }
                double[,] Pereschetmas = new double[m, n];
                double vedEl = mas[StrokaVedEl, StolbetsVedEl];
                for (int j = 0; j < n; j++)
                {
                    Pereschetmas[StrokaVedEl, j] = mas[StrokaVedEl, j] / vedEl;
                    if (Pereschetmas[StrokaVedEl, j] != 0)
                    {
                        for (int i = 0; i < m; i++)
                        {
                            if (j != StolbetsVedEl && i != StrokaVedEl)
                            {
                                Pereschetmas[i, j] = (mas[i, j] * vedEl - mas[StrokaVedEl, j] * mas[i, StolbetsVedEl]) / vedEl;
                            }
                            else { if (i != StrokaVedEl) Pereschetmas[i, j] = 0; }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < m; i++)
                        {
                            if (i != StrokaVedEl)
                                Pereschetmas[i, j] = mas[i, j];
                        }
                    }

                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mas[i, j] = Pereschetmas[i, j];
                    }
                }
                Console.WriteLine("\n Итерация");
                for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                            {
                                Console.Write(mas[i, j] + " ");
                            }
                        Console.WriteLine();
                    }
            }
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            double[] otvet_x = new double[m];
            for (int j = 0; j < kolvokor; j++)
            {
                if (mas[m - 1, j] == 0)
                {
                    int i = m - 1;
                    while (mas[i, j] != 1)
                    {
                        i--;
                    }
                    otvet_x[j] = mas[i, n - 1];
                }
                else { otvet_x[j] = 0; }
            }
            for (int j = 0; j < kolvokor; j++)
            {
                Console.WriteLine("\nx" + j + " = " + Math.Round(otvet_x[j], 2));
            }
            Console.ReadKey();
        }
    }
}