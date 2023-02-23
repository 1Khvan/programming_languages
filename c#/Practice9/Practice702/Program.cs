// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int sumCifr(int n, int m)
{
    if (n == m)
        return n;
    return sumCifr(n,m - 1) +  m;
}


Console.Clear();
Console.Write("Введите число1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumCifr(n,m));
