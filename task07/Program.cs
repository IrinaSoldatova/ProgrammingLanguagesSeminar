/*
7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

System.Console.WriteLine();

int number = new Random().Next(100, 1000);

System.Console.WriteLine($"Последней цифрой числа {number} является цифра {number%10}");
System.Console.WriteLine();
