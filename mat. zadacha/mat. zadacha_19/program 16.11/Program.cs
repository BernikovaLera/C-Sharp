using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_16._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            string A = Convert.ToString(Console.ReadLine());
            string B = Convert.ToString(Console.ReadLine());
            int [,] dp = new int [100,100];
            int ans = 0;
            for(int i=0;i<=N;i++)
                for(int j=0;j<=M;j++)
                {
                    ans=Math.Max(ans,dp[i,j]);
                    if (i < N && j < M && A[i] == B[j]) dp[i + 1, j + 1] = Math.Max(dp[i + 1, j + 1], dp[i, j] + 2);
                    if (i < N) dp[i + 1, j] = Math.Max(dp[i + 1, j], dp[i, j] - 1);
                    if (j < M) dp[i, j + 1] = Math.Max(dp[i, j + 1], dp[i, j] - 1);
                }
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());
            //string  = Convert.ToString(Console.ReadLine());
            //string  = Convert.ToString(Console.ReadLine());

            //string n[A]  = new  string;

            //Operation operation = (x, y) => x + y;
            //Console.WriteLine(operation(10, 20));
            //Console.WriteLine(operation(40, 20));
            //Console.Read();