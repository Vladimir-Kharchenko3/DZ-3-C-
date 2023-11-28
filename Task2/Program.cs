
// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.


using System;

class Program
{
    static void Main()
    {
        
        Random random = new Random();

        
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101); 
            Console.Write($"\t{numbers[i]}");
        }

        
        int countEvenFor = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                countEvenFor++;
            }
        }
        

        Console.WriteLine($"\nКоличество чётных чисел в массиве: {countEvenFor}");
        
    }
}
