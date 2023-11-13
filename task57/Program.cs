// 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раза
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Clear();

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array2D = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2D[i, j] = new Random().Next(min, max);
        }
    }
    return array2D;
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

void FrequencyDictionary(int[,] array, int max)
{
    for (int number = 0; number < max; number++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == number)
                {
                    count++;
                }
            }


        }
        System.Console.WriteLine($"{number} встречается в массиве {count} раз");
    }
}
System.Console.Write("Задайте количество строк: ");
int userRows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте количество столбцов: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте диапазон массива от: ");
int userMin = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте диапазаон массива до: ");
int userMax = Convert.ToInt32(Console.ReadLine());
int[,] array2D = FillArray(userRows, userColumns, userMin, userMax);
Print2DArray(array2D);
FrequencyDictionary(array2D, userMax);