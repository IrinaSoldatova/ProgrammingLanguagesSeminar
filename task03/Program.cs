/*
3. Напишите программу, которая будет выдавать 
название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());


if (day == 1)
{
    System.Console.WriteLine("Сегодня понедельник");
}
else if (day == 2)
{
    System.Console.WriteLine("Сегодня вторник");
}
else if (day == 3)
{
    System.Console.WriteLine("Сегодня среда");
}
else if (day == 4)
{
    System.Console.WriteLine("Сегодня четверг");
}
else if (day == 5)
{
    System.Console.WriteLine("Сегодня пятница");
}
else if (day == 6)
{
    System.Console.WriteLine("Сегодня суббота");
}
else if (day == 7)
{
    System.Console.WriteLine("Сегодня воскресенье");
}
else
System.Console.WriteLine("Нет такого дня недели");