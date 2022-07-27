using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год ");
            int n = Convert.ToInt32(Console.ReadLine());
            n++;
            while (proverca(Razbor(n))==true && n<9000) // 
            {
                n++;
            }
            Console.Write("Ответ= " + n);
            Console.ReadKey();
        }
        static int[] Razbor(int n)
    {
        int []a=new int[4];  // создание массива и запись в массив в обратном порядке для проверки
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = n % 10; // число mod 10
            n = n / 10;    // число div 10
        }
        return a;
    }
        static bool proverca(int[] a)  // проверка каждого с каждым если есть одинаковые то возвращается true иначе false
        {
            for(int i=0; i<a.Length; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if(a[i]==a[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
