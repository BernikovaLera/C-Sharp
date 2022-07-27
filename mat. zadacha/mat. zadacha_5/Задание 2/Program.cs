using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] nums = new int[30];
            for (int i = 0; i < nums.Length; ++i)
            {
                nums[i] = rnd.Next(0, 100);
                Console.Write(" " + nums[i]);
            }
        }
    }
}
