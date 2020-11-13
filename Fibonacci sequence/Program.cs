using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fibonacci_sequence
{
    /// <summary>
    /// 用来计算伪菲波那契数列，之所以叫伪菲波那契数列，是因为数列开始是从1
    /// </summary>
    //1、1、2、3、5、8、13、21、34
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("计算菲波那契数列第30位的值是");
            
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            //Console.WriteLine(fib(30));
            solution1();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
            Console.ReadKey();

        }


        /// <summary>
        /// 使用List实现
        /// </summary>
        public static void solution1()
        {
            List<int> lstINt = new List<int>() { 1 };
            while (lstINt.Count < 30)
            {
                if (lstINt.Count == 1)
                {
                    lstINt.Add(1);
                }
                else
                {
                    lstINt.Add(lstINt[lstINt.Count - 2] + lstINt[lstINt.Count - 1]);
                }

            }
            //Console.WriteLine(string.Join(',', lstINt.ToArray()));
            Console.WriteLine($"第30位结果是{lstINt[(30 - 1)]}");
            
        }

        private static int fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            //Console.WriteLine($"fib({n - 1}) + fib({n - 2})");
            return fib(n - 1) + fib(n - 2);
        }
    }
}
