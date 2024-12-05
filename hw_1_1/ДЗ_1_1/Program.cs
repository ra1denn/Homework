using System;

namespace task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int maxNumber;
            while (!int.TryParse(Console.ReadLine(), out maxNumber) || maxNumber < 2)
            {
                Console.WriteLine("введите число больше 1");
            }

            Console.WriteLine($"Простые числа до {maxNumber}:");

            for (int number = 2; number <= maxNumber; number++)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static bool IsPrime(int n)
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
