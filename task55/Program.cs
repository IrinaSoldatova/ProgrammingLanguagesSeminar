// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для 
// пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

Console.Clear();

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void RowsEqualColumns(int[,] arr)
{
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        System.Console.WriteLine("Невозможно заменить строки на столбцы");
        return;
    }
    SwapRowsAndColumns(arr);
    Print2DArray(arr);
}

void SwapRowsAndColumns(int[,] arr)
{
    int[,] newArray = new int[arr.GetLength(1), arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int tmp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = tmp;
        }
    }
}



int[,] array2D = new int[3, 3];
FillArray(array2D);
Print2DArray(array2D);
System.Console.WriteLine();
RowsEqualColumns(array2D);