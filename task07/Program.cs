/*
7. Напишите программу, которая принимает на вход трёхзначное
 число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    System.Console.WriteLine($"Последней цифрой числа {number} является цифра {number % 10}");
}
else
{
    System.Console.WriteLine("Введенное число не трёхзначное");
}