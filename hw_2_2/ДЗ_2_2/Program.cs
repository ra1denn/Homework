using System;

namespace task2_2
{
    class Program
    {
        public static int rekursFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * rekursFactorial(n - 1);
            }

        }

        public static int iterFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int res = 1;
                for (int i = 1; i <= n; i++)
                {
                    res *= i;
                }
                return res;
            }
        }

            static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n + "! = " + rekursFactorial(n) + " рекурсия");
            Console.WriteLine(n + "! = " + iterFactorial(n) + " итерация");
        }
    }
}
