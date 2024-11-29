using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        Console.WriteLine("ведите число n");
        int n = Convert.ToInt32(Console.ReadLine());
        int counter = 0;
        while (n != 1)
        {
            if (n%2==0)
            {
                n /= 2;
                counter++;
            }

            else
            {
                n = 3 * n + 1;
                counter++;
            }
        }

        Console.WriteLine("кол-во замен для достижения 1:" + counter);


    }
}