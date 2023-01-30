// 12 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1,  то программа выводит остаток от деления.

Console.Clear();

Console.Write("Введите первое число: ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = Convert.ToInt32(Console.ReadLine());

double count = a % b;
if (count == 0)
{
    Console.Write($"Кратно");

}
    else
    {
        Console.Write($"Не кратно {count}");
    }


