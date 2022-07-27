using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; ++i)
            {
                nums[i] = rnd.Next(0, 100);
               Console.Write(" " + nums[i]);
            }
        string s = Convert.ToString(Console.ReadLine());
        Console.WriteLine(s == "min"? min(nums):max(nums));
        Console.ReadKey();
        }
        static int min(int [] a )
       {
           int m = a[1];
            for (int i= 0; i < a.Length; i++)
            {
                if (a[i]<m)
                {
                    m = a[i];
                }
            }
            return m;
       }
        static int max(int [] a )
       {
           int m = a[1];
            for (int i= 0; i < a.Length; i++)
            {
                if (a[i]>m)
                {
                    m = a[i];
                }
            }
            return m;
       }
    }
}