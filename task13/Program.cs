/*
Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 1000)
{
    number = number / 10;
}
if (number > 99 && number < 1000)
{
    System.Console.WriteLine(number % 10);
}
else
{
    System.Console.WriteLine("no");
}
