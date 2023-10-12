/*
Задача 19: Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является ли оно 
палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
System.Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (10000 > number || number > 99999)
{
    System.Console.WriteLine("Введенное число не является пятизначным");
    return;
}
for (int i = number; i < 10; i = i % 10)
{
    i = i / 10;
}
System.Console.WriteLine();




/*
int num1 = number % 10;
int num2 = number / 10 % 10;
int num3 = number / 100 % 10;
int num4 = number / 1000 % 10;
int num5 = number / 10000 % 10;
int number2 = num1 * 10000 + num2 * 1000 + num3 * 100 + num4 * 10 + num5;
System.Console.WriteLine(number2);
if (number == number2)
{
    System.Console.WriteLine("True");
}
else
{
    System.Console.WriteLine("False");
}

*/
