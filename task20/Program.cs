/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
System.Console.WriteLine("Введите координаты точки A(x, y): ");
double userAx = Convert.ToInt32(Console.ReadLine());
double userAy = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B(x, y): ");
double userBx = Convert.ToInt32(Console.ReadLine());
double userBy = Convert.ToInt32(Console.ReadLine());
 
double squareX = Math.Pow(userBx - userAx, 2); //возведение в степень
double squareY = Math.Pow(userBy - userAy, 2);
double rootXY = Math.Sqrt(squareX + squareY);// находит квадратный корень
System.Console.WriteLine(Math.Round(rootXY, 2));//округление, 2 - сколько символов после запятой оставить