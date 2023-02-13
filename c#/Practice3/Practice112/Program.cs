// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++) // Вариант 1
    Console.Write($"{i * i * i} ");

// int i = 1; // Вариант 2
// while (i <= n)
// {
//     Console.Write($"{i * i * i} ");
//     i++; // i = i + 1;
// }