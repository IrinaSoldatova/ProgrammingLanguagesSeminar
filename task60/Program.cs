// Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
Console.Clear();

void Fill3DArray(int[,,] arr)
{
    //int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                //arr[i, j, k] = arr[i, j, k] + count;
                //count++;
                arr[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}


void ReplaceDuplicateElements(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int element = array[i, j, k];
                int newElement = new Random().Next(10, 100);

                while (ArrayContainsElement(array, newElement))
                {
                    newElement = new Random().Next(10, 100);
                }

                array[i, j, k] = newElement;
            }
        }
    }
}

bool ArrayContainsElement(int[,,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == element)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void Print3DArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]} [{i}, {j}, {k}]\t");
            }
            System.Console.WriteLine();
        }
    }

}

int[,,] array3D = new int[4, 4, 4];
Fill3DArray(array3D);
ReplaceDuplicateElements(array3D);
Print3DArray(array3D);

















// void FrequencyDictionary(int[,,] array)
// {
//     for (int number = 10; number < 100; number++)
//     {
//         int count = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 for (int k = 0; k < array.GetLength(2); k++)
//                 {
//                     if (array[i, j, k] == number)
//                     {
//                         count++;
//                     }
//                 }
//             }


//         }
//         System.Console.WriteLine($"{number} встречается в массиве {count} раз");
//     }
// }

// FrequencyDictionary(array3D);