// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


void Number(int num)
{
    int decimalNumber = 0;
    for (int i = num; i > 0; i = i / 2)
    {
        if (i == 1) decimalNumber = 1;
        if (i % 2 == 0) decimalNumber = 0;
        else decimalNumber = 1;
        System.Console.Write(decimalNumber);
        System.Console.Write("\t");
    }
    System.Console.WriteLine();

 }

string Conv(int number)
{
    string result ="";
    int tmp = 0;
    for (int i = number; i > 0; i/=2)
    {
        tmp = i % 2;
        result = tmp + result;
    }
    return result;

}


System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
string result = Conv(userNumber);
System.Console.Write(result);


