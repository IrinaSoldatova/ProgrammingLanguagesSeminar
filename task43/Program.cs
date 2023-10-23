// Задача 43. Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + 
// b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -
// > (-0,5; -0,5)

Console.Clear();
void IntersectionPoint(double k1, double b1, double k2, double b2)
{

    double num = b1 - b2;
    double denom = k1 - k2;
    if (num < 0) num = (- num);
    if (denom < 0) denom = (- denom);
    double x = num / denom;
    if (x < 0) x = -x;
    System.Console.WriteLine(x);
    double y = (k2 * (x)) + b2;
    System.Console.WriteLine(y);

}



System.Console.Write("ВВедите точку k1: ");
double userK1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("ВВедите точку b1: ");
double userB1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("ВВедите точку k2: ");
double userK2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("ВВедите точку b2: ");
double userB2 = Convert.ToDouble(Console.ReadLine());
IntersectionPoint(userK1, userB1, userK2, userB2);
