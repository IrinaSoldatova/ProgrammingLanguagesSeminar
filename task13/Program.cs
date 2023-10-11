/*
Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    System.Console.WriteLine("нет третьей цифры");
    return;

}

while (number > 1000)
{
    number = number / 10;
}

System.Console.WriteLine(number % 10);

/*
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    System.Console.WriteLine("нет третьей цифры");
    return;
}

for (int i = number; i >= 100; i = i / 10)
{
    number = i % 10;
}
System.Console.WriteLine(number);
*/
