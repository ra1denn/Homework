using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число");

        try
        {
            string input = Console.ReadLine();
            int number = ConvertToInt(input);
            Console.WriteLine($"число: {number}");
        }

        catch (FormatException)
        {
            Console.WriteLine("не число");
        }

        catch (OverflowException)
        {
            Console.WriteLine("число слишком большое или слишком маленькое");
        }
    }

    static int ConvertToInt(string input)
    {
        return int.Parse(input);
    }
}