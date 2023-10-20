// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}
void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write("\t");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}
void MinMaxNumber(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        else if(array[i] > max) max = array[i];
    }
    System.Console.WriteLine($"Минимальный элемент массива = {min}");
    System.Console.WriteLine($"Максимальный элемент массива = {max}");
    System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min:F2}");
}


Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArray(array);
PrintArray(array);
MinMaxNumber(array);