// Задача 29: Напишите программу, которая задаёт
//  массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

void FillArray(int[] size)
{
    for (int i = 0; i < size.Length; i++)
    {
        System.Console.WriteLine("Введите n: ");
        size[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int j = 0; j < arr.Length - 1; j++)
    {
        System.Console.Write(arr[j]);
        if (j < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write($"{arr[arr.Length - 1]}");
    System.Console.Write("]");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);



/*
using System;
Console.Clear();

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine("Введите n: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
}
int[] userArray = FillArray(8);
PrintArray(userArray);
*/