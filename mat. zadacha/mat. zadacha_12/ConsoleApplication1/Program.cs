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
            int[] array = { 1,4,3,1,2 };
            int[] subarray = { 1,2,3,4,5,6 };
            Matrix mt = new Matrix();
            int i = mt.IndexArr(array, subarray);
            if (i > -1)
            {
                Console.WriteLine(Convert.ToString(i));
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.ReadLine();
        }

    }

    public class Matrix
    {
        public int IndexArr(int[] array, int[] subarray)
        {
            int index = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == subarray[count])
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == subarray.Length)
                {
                    index = i - count + 1;
                    return index;
                }
            }
            return -1;
        }
    }
}
