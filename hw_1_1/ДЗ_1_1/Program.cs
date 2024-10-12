using System;

namespace task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int n = 2; n <= number; n++)
            {
                if (isPrime(n))
                {
                    Console.WriteLine(n);
                }
            }

        }

        static bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
