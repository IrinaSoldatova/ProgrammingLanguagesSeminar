/*
Программа которая принимает на вход
 три числа и выдаёт максимальное из этих чисел.
*/

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (a > b && a > c)
{
    max = a;
}
else if (b > c)
{
    max = b;
}
else
{
    max = c;
}

Console.WriteLine(max);
