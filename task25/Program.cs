// Задача 25: Напишите цикл, который принимает
//  на вход два числа (A и B) и возводит число 
//  A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
System.Console.WriteLine("Введите первое число ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Math.Pow(A, B));
*/
System.Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());


int Degree(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

int userResalt = Degree(numberA, numberB);
System.Console.WriteLine(userResalt);
