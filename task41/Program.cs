// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


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
    System.Console.WriteLine("]");
    
}
void ResultNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) result++;
    }
    System.Console.WriteLine(result);
}

System.Console.Write("Задайте размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userArray = FillArray(userSize);
PrintArray(userArray);
ResultNumber(userArray);






/*
Console.Clear();

int[] FillArray(int size)
{
    int[] array = new int[size];
    
    Console.WriteLine("Введите массив через пробел: ");
    string userArr = Console.ReadLine();
    string[] uArray = userArr.Split(' ');
    
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(uArray[i]);
    }
    
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

void ResultNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) 
            result++;
    }
    Console.WriteLine(result);
}

Console.Write("Задайте размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userArray = FillArray(userSize);
PrintArray(userArray);
ResultNumber(userArray);
*/