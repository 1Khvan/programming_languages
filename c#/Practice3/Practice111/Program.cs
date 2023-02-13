// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.Write("Введите координату 1й точки по Х: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату 1й точки по Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату 1й точки по Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату 2й точки по Х: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату 2й точки по Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату 2й точки по Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());


double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z2 - z1, 2)), 2);
Console.WriteLine($"Результат: расстояние между точками {l}");