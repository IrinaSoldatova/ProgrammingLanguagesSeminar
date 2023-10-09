/*
Напишите программу которая на вход принимает число (number), 
а на выходе выводит все чётные числа от 1 до number (включительно), 
разделеные знаком табуляции.
*/

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i<= userNumber; i++)
{
//int remain = i % 2;
//if (remain == 0)
if(i % 2 == 0)
System.Console.Write(i+"\t");
}
