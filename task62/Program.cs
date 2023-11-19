// Задача 62: Заполните спирально массив 4 на 4.

 Console.Clear();

void FillArraySpiral(int[,] arr)
{
    int value = 1; // Начальное значение для заполнения массива
    int startX = 0, startY = 0; // Начальные координаты для заполнения
    int endX = 3, endY = 3; // Конечные координаты для заполнения

    // Заполняем массив по спирали
    while (startX <= endX && startY <= endY)
    {
        // Заполнение верхней строки
        for (int i = startX; i <= endX; i++)
        {
            arr[startY, i] = value;
            value++;
        }
        startY++;

        // Заполнение правого столбца
        for (int i = startY; i <= endY; i++)
        {
            arr[i, endX] = value;
            value++;
        }
        endX--;

        // Заполнение нижней строки
        for (int i = endX; i >= startX; i--)
        {
            arr[endY, i] = value;
            value++;
        }
        endY--;

        // Заполнение левого столбца
        for (int i = endY; i >= startY; i--)
        {
            arr[i, startX] = value;
            value++;
        }
        startX++;
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write("0" + arr[i, j]);
                System.Console.Write(" ");
            }
            else Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
FillArraySpiral(array);
PrintArray(array);