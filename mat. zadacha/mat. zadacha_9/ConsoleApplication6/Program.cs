using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
            {
                int k = 0;
                var a = s.Split(' ');
                int[] mas = new int[a.Length];
                for (int i = 0; i < n; i++)
                    {
                        mas[i] = int.Parse(a[i]);
                    }
                    for (int i = 0; i < n - 1; i++) 
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            if ((mas[i] + mas[j]) % 2 == 1 && (mas[i] * mas[j]) % 13 == 0 && j - i < 5)
                                {
                                    k++;
                                }
                        }
                    }
                    Console.WriteLine(k+"","Ответ");
            }
    }
} 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        int x = Convert.ToInt32(Console.ReadLine());
    //        int k = 0;
    //        int z = 0;
    //        int[] a = new int[5];
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine(a[5]);
    //        }
    //        for (int i = 5; i < 5; i++)
    //        {
    //            Console.WriteLine(x);
    //            if (a[i % 5] % 13 == 0) { z++; }
    //            if (x % 13 == 0) { k = k + i - 4; }
    //            else { k = k + z;
    //                a[i % 5] = x; }
    //        }
    //        Console.WriteLine(k);
    //        Console.ReadKey();
    //    }
    //} 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        int k = 0;
    //        int z = 0;
    //        int mas[] = new int[n];
    //        for(int i = 0; i < 5; i++)
    //        {
                
    //        }
    //        for(int i = 5; i < n; i++)
    //        {
    //            if(mas[i%5]%13==0) 
    //                z++;
    //            if(x%13==0) 
    //                k=k+i-4;
    //            else k=k+z;
    //            mas[i%5]=x;
    //        }
    //        Console.WriteLine(k);
    //        Console.ReadKey();
    //    }
    //}

