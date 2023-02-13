// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.Write($" Больше: {a}, Меньше: {b} ");
else
    Console.WriteLine($" Больше: {b}, Меньше: {a} ");

