// 28. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.WriteLine("Введите число ");
int userA = Convert.ToInt32(Console.ReadLine());

int Summa(int a)
{
    int sum = 1;
    for (int i = 1; i <= a; i++)
    {
        sum = sum * i;
    }
    return sum;
}
int userResalt = Summa(userA);
System.Console.WriteLine(userResalt);


