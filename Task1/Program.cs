//  Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//  Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int size = Convert.ToInt32(Console.ReadLine());

        
        int[] numbers = new int[size];

        Console.WriteLine("Введите элементы массива:");

        
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        int countInRangeFor = 0;
        for (int i = 0; i < size; i++)
        {
            if (numbers[i] >= 20 && numbers[i] <= 90)
            {
                countInRangeFor++;
            }
        }

        Console.WriteLine($"Количество элементов в отрезке [20, 90]: {countInRangeFor}");
    
    }
}
