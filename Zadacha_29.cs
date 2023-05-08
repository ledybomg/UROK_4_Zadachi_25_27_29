// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


using System;

class Program
{
    static void Main()
    {
        int[] array = new int[8];

        Console.WriteLine("Введите 8 чисел:");
        for (int i = 0; i < 8; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
