﻿/*
напишите программу, которая на вход принимает число number
 и выводит, является ли число чётным (делится ли оно на два без остатка).

number = 4 -> Число 4 чётное

number = 3 -> Число 3 нечётное

number = 7 -> Число 7 нечётное
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


    if (number % 2 == 0)
    {
        Console.WriteLine($"Число {number} четное");
    }
    else
    {
        Console.WriteLine($"Число {number} нечетное");
    }

