/* 16 Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.*/

Console.Clear();

Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b * b == a || a * a == b)
    Console.WriteLine("Да!");

else
    Console.WriteLine("Нет!");