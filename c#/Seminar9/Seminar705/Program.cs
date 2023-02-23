// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int rec(int n, int m)
{
    if (m == 0)
        return 1;
    return rec(n, m - 1) * n;
}


Console.Clear();
Console.Write("Введите число1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(n,m));