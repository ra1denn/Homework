using System;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "f.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("x sin(x)");
            for (double x = 0; x <= 1; x += 0.1)
            {
                double sinVal = Math.Sin(x);

                writer.WriteLine($"{x:F1} {sinVal:F5}");
            }
        }

        Console.WriteLine($"Таблица значений sin(x) записана в файл {filePath}");
    }
}
