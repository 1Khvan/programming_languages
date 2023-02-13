// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


Console.Clear();
Console.Write("Введите # четверти: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a == 1 || a > 4)
{
    Console.Write("Вы ошиблись!\n Введите # четверти: ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a == 1)
    Console.WriteLine("x > 0 ; y > 0");
else if (a == 2)
    Console.WriteLine("x < 0 ; y > 0");
else if (a == 3)
    Console.WriteLine("x < 0 ; y < 0");
else
    Console.WriteLine("x > 0 ; y > 0");
