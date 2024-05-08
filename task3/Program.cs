﻿// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static Random random = new Random();

    static void PrintReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintReverse(array, index - 1);
        }
    }

    static void Main(string[] args)
    {
        int[] array = new int[10];
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Массив в обратном порядке:");
        PrintReverse(array, array.Length - 1);
    }
}