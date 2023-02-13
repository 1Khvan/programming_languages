// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Clear();
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 10000 || a > 99999)
{
    Console.Write("Вы ошиблись!\a Введите пятизначное число: ");
    a = Convert.ToInt32(Console.ReadLine());
}

int a0 = a % 10;
int a1 = a / 1000 % 10;
int a3 = a / 10 % 10;
int a4 = a / 10000;

if (a0 == a4 && a1 == a3)
    Console.Write($"{a} палиндром");
else
    Console.Write($"{a} не палиндром");
