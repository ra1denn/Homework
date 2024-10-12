using System;

namespace task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Коэффициент а:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Коэффициент b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Коэффициент с:");
            double c = Convert.ToDouble(Console.ReadLine());

            double discr = b * b - 4 * a * c;

            if (a != 0 & b != 0 & c != 0)
            {
                if (discr > 0)
                {
                    double x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discr)) / (2 * a);

                    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                }

                else if (discr == 0)
                {
                    double x = -b / (2 * a);

                    Console.WriteLine($"x = {x}");
                }

                else
                {
                    Console.WriteLine("нет действительных решений");
                }
            }

            else if (b == 0 & a != 0 & b != 0)
            {
                if ((-c / a) > 0)
                {
                    double x1 = Math.Sqrt((-c / a));
                    double x2 = -(Math.Sqrt((-c / a)));

                    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                }

                else
                {
                    Console.WriteLine("нет решений");
                }
            }

            else if (c == 0 & a != 0 & b != 0 & a > 0)
            {
                double x1 = b / a;
                double x2 = 0;

                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }

            else if (b == 0 & c == 0)
            {
                double x = 0;

                Console.WriteLine($"x = {x}");
            }

            else
            {
                Console.WriteLine("бесконечно много решений");
            }


        }
    }
}