// 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();

void Fibonacci(int number)
    {
        int[] arr = new int[number];
        for (int i = 0; i < number; i++)
        {
            if (i < 2) arr[i] = i;
            else arr[i] = arr[i - 1] + arr[i - 2];
            System.Console.Write($"{arr[i]} ");
        }
    }
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Fibonacci(userNumber);


