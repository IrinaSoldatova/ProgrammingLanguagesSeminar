// Задача 30: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

/*
void FillArray(int[] size)
{
    for (int i = 0; i < size.Length; i++)
    {
        size[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        System.Console.Write($"{arr[j]}, ");
    }
}

int[] array = new int[9];

FillArray(array);
PrintArray(array);
*/

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
        System.Console.Write($"{arr[i]}, ");
    }
}
int[] userArray = GetRandArray(9);
PrintArray(userArray);
