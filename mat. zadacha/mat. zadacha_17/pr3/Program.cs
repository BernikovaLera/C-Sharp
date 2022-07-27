using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    class Program
    {
        static void Vichislenie(double[,] mas, int m, int n)
        {
            int proverka_yslovia = 0;
            double sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    sum += Math.Abs(mas[i, j]);
                }
                if (Math.Abs(mas[i, i]) < (sum - Math.Abs(mas[i, i]))) { proverka_yslovia++; }
                sum = 0;
            }

            if (proverka_yslovia == 0)
            {
                for (int i = 0; i < m; i++)
                {
                    double p = mas[i, i];
                    for (int j = 0; j < n; j++)
                    {
                        mas[i, j] = Math.Round(mas[i, j] / p, 4);
                    }
                }
                double[] xmin = new double[m];
                double[] x = new double[m];
                int k_e;
                double etoch = Math.Pow(10, -3);
                for (int i = 0; i < m; i++)
                    xmin[i] = mas[i, n - 1];
                int k = 0;
                do
                {
                    for (int i = 0; i < m; i++)
                    {
                        double pro = 0;
                        for (int j = 0; j < n - 1; j++)
                        {
                            pro += Math.Round(mas[i, j] * xmin[j], 4);
                        }
                        x[i] = Math.Round(mas[i, n - 1] - (pro - mas[i, i] * xmin[i]), 4);
                    }
                    k_e = 0;
                    for (int i = 0; i < m; i++)
                        if (Math.Abs(x[i] - xmin[i]) > etoch) { k_e++; }
                    for (int z = 0; z < m; z++)
                        xmin[z] = x[z];
                    k++;
                } while (k_e > 0);
                if (m == 4)
                {
                    Console.WriteLine("x1 = " + x[0] + "; x2 = " + x[1] + "; x3 = " + x[2] + "; x4 = " + x[3], "Ответ для 1: ");
                    Console.WriteLine("Кол-во: " + k, "Ответ для 1: ");
                }
                if (m == 3)
                {
                    Console.WriteLine("x1 = " + x[0] + "; x2 = " + x[1] + "; x3 = " + x[2], "Ответ для 2: ");
                    Console.WriteLine("Кол-во: " + k, "Ответ для 2: ");
                }
            }
            else
            {
                if (m == 4)
                    Console.WriteLine("Условие преобладания диагональных элементов НЕ вполняется!", "Ответ для 1: ");

                if (m == 3)
                    Console.WriteLine("Условие преобладания диагональных элементов НЕ вполняется!", "Ответ для 2: ");
            }
        }
        static void Main(string[] args)
        {
            int m = 4;
            int n = 5;
            double[,] mas = new double[m, n];
            Console.WriteLine("Введите значения первой матрицы: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Vichislenie(mas, m, n);
            m = 3;
            n = 4;
            Console.WriteLine("Введите значения второй матрицы: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Vichislenie(mas, m, n);
            Console.ReadKey();
        } 
    }
}
