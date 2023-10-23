// Задача 40: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

bool Triangle(int numA, int numB, int numC)
{
    if (numA < numB + numC && numB < numA + numC && numC < numA + numB)
        return true;
    else return false;
}

System.Console.WriteLine("Введите число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число c: ");
int numberC = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Triangle(numberA, numberB, numberC));
