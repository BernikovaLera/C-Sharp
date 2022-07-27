using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пр_4
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
                double[] y = new double[m];
                int k_e;
                double etoch = 0.005;
                for (int i = 0; i < m; i++)
                {
                    xmin[i] = mas[i, n - 1];
                    y[i] = mas[i, n - 1];
                }
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
                        y[i] = x[i];
                    }
                    k_e = 0;
                    for (int i = 0; i < m; i++)
                        if (Math.Abs(x[i] - xmin[i]) > etoch) { k_e++; }
                    for (int i = 0; i < m; i++)
                        xmin[i] = x[i];
                    k++;
                } while (k_e > 0);

                Console.WriteLine("x1 = " + x[0] + "; x2 = " + x[1] + "; x3 = " + x[2], "Ответ: ");
                Console.WriteLine("Кол-во: " + k, "Ответ: ");

            }
            else
            {
                Console.WriteLine("Условие преобладания диагональных элементов НЕ вполняется!", "Ответ: ");
            }
        }
        static void Main(string[] args)
        {
            int m = 3;
            int n = 4;
            double[,] mas = new double[m, n];
            Console.WriteLine("Введите значения первой матрицы: ");
            for (int i = 0; i < m; i++)
            {
                int[] row = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = row[j];
                }
            }
            for (int j = 0; j < n; j++)
            {
                double t = mas[1, j];
                mas[1, j] = mas[2, j];
                mas[2, j] = t;
            }
            Vichislenie(mas, m, n);
            Console.WriteLine("Введите значения второй матрицы: ");
            for (int i = 0; i < m; i++)
            {
                int[] row = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = row[j];
                }
            }
            for (int j = 0; j < n; j++)
            {
                double t = mas[0, j];
                mas[0, j] = mas[1, j];
                mas[1, j] = t;
            }
            for (int j = 0; j < n; j++)
            {
                double t = mas[0, j];
                mas[0, j] = mas[2, j];
                mas[2, j] = t;
            }
            Vichislenie(mas, m, n);
            Console.ReadKey();
        }
    }
}
