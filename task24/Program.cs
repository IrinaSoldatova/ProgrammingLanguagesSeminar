/*
24. Напишите программу, которая принимает 
на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
System.Console.WriteLine("Введите число ");
int userA = Convert.ToInt32(Console.ReadLine());

int Summa(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int userResalt = Summa(userA);
System.Console.WriteLine(userResalt);