/*
Задача 19: Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является ли оно 
палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

System.Console.Write("Введите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (10000 > userNumber || userNumber > 99999)
{
    System.Console.WriteLine("Число не пятизначное");
    return;
}


int reverse = 0;

for (int number = userNumber; number > 0; number = number / 10)
{
    int remain = number % 10;
    reverse = reverse * 10 + remain;
}
if(userNumber == reverse)
{
    System.Console.WriteLine("Чиcло является палиндромом");

}
else
{
    System.Console.WriteLine("Не является палиндромом");
}






/* второй способ

System.Console.Write("Введите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (10000 > userNumber || userNumber > 99999)
{
    System.Console.WriteLine("Число не пятизначное");
    return;
}

int number = userNumber;
int reverse = 0;

while (number > 0)
{
    int remain = number % 10;
    reverse = reverse * 10 + remain;
    number = number / 10;
}

if(userNumber == reverse)
{
    System.Console.WriteLine("Чиcло является палиндромом");

}
else
{
    System.Console.WriteLine("Не является палиндромом");
}
*/


/* третий способ

System.Console.Write("Введите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (10000 > userNumber || userNumber > 99999)
{
    System.Console.WriteLine("Число не пятизначное");
    return;
}

int num1 = userNumber % 10;
int num2 = userNumber / 10 % 10;
int num3 = userNumber / 100 % 10;
int num4 = userNumber / 1000 % 10;
int num5 = userNumber / 10000 % 10;
int number = num1 * 10000 + num2 * 1000 + num3 * 100 + num4 * 10 + num5;
System.Console.WriteLine(number);
if (userNumber == number)
{
    System.Console.WriteLine("Чиcло является палиндромом");
}
else
{
    System.Console.WriteLine("Не является палиндромом");
}
*/

