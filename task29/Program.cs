// Задача 29: Напишите программу, которая задаёт
//  массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] size)
{
    for (int i = 0; i < size.Length; i++)
    {
        size[i] = new Random().Next(0, 35);
    }
}

void PrintArray(int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        System.Console.Write($"{arr[j]}, ");
    }
}

int[] array = new int[1, 2, 3, 4, 5, 6, 7, 8];

FillArray(array);
PrintArray(array);