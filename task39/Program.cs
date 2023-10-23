// Задача 39: Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, а первый - на 
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();

int[] FillArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
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
    System.Console.WriteLine();
}
void ReverseArray(int[] array)
{
    int tmp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        tmp = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = tmp;
    }
}


System.Console.Write("Задайте размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = FillArray(userSize);
PrintArray(userArray);
ReverseArray(userArray);
System.Console.WriteLine();
PrintArray(userArray);