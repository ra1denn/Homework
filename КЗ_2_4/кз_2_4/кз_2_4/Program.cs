using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите размер массива");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("введите элементы массива");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());

        }

        BubbleSort(array);

        Console.WriteLine("отсортированный массив: ");
        foreach (int item in array)
        {
            Console.WriteLine(item + " ");
        }
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0;i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j+1])
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
    }
}
