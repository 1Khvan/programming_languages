// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.WriteLine("Приветству!");

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a);
int a1 = a % 100;
int a3 = a % 10;


Console.WriteLine((a1-a3)/10);