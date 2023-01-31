// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.WriteLine("Приветству!");

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int a2 = a / 10;

Console.WriteLine((a2%10));