using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        public static int Index(int[] a, int[] b)
        {
            int ind = -1;
            for(int i=0;i<a.Length-b.Length+1;i++)
            {
                ind = i;
                for(int j=0;j<b.Length;j++)
                {
                    if(a[i+j] != b[j])
                    {
                        ind=1;
                        break;
                    }
                }
                if(ind>=0)
                return ind;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int [] mas = new int[n];
            for (int i = 0; i < mas.Length; i++)
            {
                if (i > -1)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
