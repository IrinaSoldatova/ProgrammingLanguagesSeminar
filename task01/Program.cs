﻿/*
1. Напишите программу, которая на вход принимает два числа
 и проверяет, является ли первое число квадратом второго. 

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет
*/

System.Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 == userNumber2 * userNumber2)       
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}

