/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
System.Console.WriteLine("Введите номер дня недели ");
int day = Convert.ToInt32(Console.ReadLine());

if (0 < day && day < 6)
{
    System.Console.WriteLine("нет, сегодня будний день");
}
else if (day == 6 || day == 7)
{
    System.Console.WriteLine("да, сегодня выходной");
}
else
{
    System.Console.WriteLine("нет такого дня недели");
}