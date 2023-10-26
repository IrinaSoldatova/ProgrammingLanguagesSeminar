// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной
// диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив: 1 47 2
//                         5 92 3
//                         8 42 4
// Сумма элементов главной диагонали: 1+9+2 = 12
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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void Dioganal(int[,] newArr)
{
    int sum = 0;
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            if (i == j ) sum += newArr[i, j];
        }
    }
    System.Console.WriteLine($"Сумма элементов главной диагонали = {sum}");
}

int[,] array2D = new int[3, 4];
FillArray(array2D);
PrintArray(array2D);
System.Console.WriteLine();
Dioganal(array2D);