System.Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 == userNumber2 * userNumber2)       
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}

