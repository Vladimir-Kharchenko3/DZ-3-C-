// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

using System;

class Program
{
    static void Main()
    {
        
        Random random = new Random();

        
        double[] numbers = new double[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            
            numbers[i] = Math.Round(random.NextDouble() * 100, 2);
        }

        double maxNumber = double.MinValue;
        double minNumber = double.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }

            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }

        
        double difference = maxNumber - minNumber;

        Console.WriteLine("Исходный массив:");
        PrintArray(numbers);

        Console.WriteLine($"\nМаксимальный элемент: {maxNumber}");
        Console.WriteLine($"Минимальный элемент: {minNumber}");
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    }
         static void PrintArray(double[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine("]");
    }
    
}