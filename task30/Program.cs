﻿// Задача 30: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

void FillArray(int[] size)
{
    for (int i = 0; i < size.Length; i++)
    {
        size[i] = new Random().Next(0, 2);
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

/* через int 
using System;
Console.Clear();

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write("[")
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
}
int[] userArray = GetRandArray(8);
PrintArray(userArray);
*/