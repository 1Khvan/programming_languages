// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Clear();

Console.WriteLine("Приветству!");

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
    Console.Write($"Третьей цифры нет");
else if (a > 100 && a < 1000)
    Console.Write($"Третья цифра: {a % 10}");
else if (a > 1000 && a < 10000)
{
    int a1 = a / 10;
    Console.Write($"Третья цифра: {a1 % 10}");
}
else if (a > 10000)
{
    int a2 = a / 100;
    Console.Write($"Третья цифра: {a2 % 10}");
}


