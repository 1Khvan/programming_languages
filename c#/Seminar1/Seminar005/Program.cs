// все целые числа в промежутке от -N до N.
Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = (-1) * n;
while (count <= n)
{
    Console.Write($"{count} ");
    count++; // count = count + 1;
}
