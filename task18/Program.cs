/*
Задача 18: Напишите программу, которая по 
заданному номеру четверти, показывает 
диапазон возможных координат точек в этой 
четверти (x и y).
*/

System.Console.WriteLine("Введите номер четверти ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1)
{
    System.Console.WriteLine("x > 0, y > 0");
}
else if (quarter == 2)
{
    System.Console.WriteLine("x < 0, y > 0");
}
else if (quarter == 3)
{
    System.Console.WriteLine("x < 0, y < 0");
}
else if (quarter == 4)
{
    System.Console.WriteLine("x > 0, y < 0");
}
else
{
    System.Console.WriteLine("нет такой четверти");
}
