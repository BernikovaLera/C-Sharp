using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данные ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int  mn=1000000000;
            for(int i=1;i<=n;i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if(x>0&&x<=k) mn=Math.Min(mn,Math.Abs(m-i));
            }
            Console.WriteLine("Ответ: " + mn * 10);
            Console.ReadKey();
        }
    }
}