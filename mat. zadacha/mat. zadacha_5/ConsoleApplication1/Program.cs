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
            Random rnd = new Random();
            int[] nums = new int[10];
            int index1=0, index2=0;
            for (int i = 0; i < nums.Length; ++i)
            {
                nums[i] = rnd.Next(0, 20);
                Console.Write(" " + nums[i]);
            }
            int min = Math.Abs(nums[0] - nums[1]);
            for (int i = 0; i < nums.Length; ++i)
            {
                for (int j = 0; j < nums.Length; ++j) 
                {
                    if (Math.Abs(nums[i]) - nums[j] < min && i!=j)
                    {
                        index1 = i;
                        index2 = j;
                        min = Math.Abs(nums[i] - nums[j]);
                    }
                }
            }
            Console.WriteLine(" index1:" + (index1 + 1) + " index2:" + (index2 + 1));
                Console.ReadKey();
            }
        }
    }

