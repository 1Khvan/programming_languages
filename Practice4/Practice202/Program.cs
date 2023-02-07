// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (a > 0)
{
int a1 = a % 10;
a = a / 10;
sum = sum + a1;
}
Console.WriteLine($"Cумма всех цифр в числе равна: {sum}" );
