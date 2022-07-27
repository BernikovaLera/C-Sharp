using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_23._11
{
    class Program
    {
        //public static bool IsArr(string[] arr, string str)
        //{

        //}
        static void Main(string[] args)
        {
            try
            {
            string[] a = new string[4];
            string[] b = new string[5];
            string[] k = new string[0];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    string m = a[i] + b[j];
                    if (k.Length > 1)
                    {
                        k[k.Length - 1] = m;
                    }
                }
            }
            }
                catch
                {

                }


                Console.WriteLine("Конец программы");
                Console.Read();
            }

        }
    }
