// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Clear();

Console.Write("Введите номер дня недели, от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.WriteLine("Рабочий день: Понедельник - день тяжелый");
else if (n == 2)
    Console.WriteLine("Рабочий день: Вторник - самый второй день недели");
else if (n == 3)
    Console.WriteLine("Рабочий день: Среда пришла — неделя прошла.");
else if (n == 4)
    Console.WriteLine("Рабочий день: Четверг - маленькая Пятница");
else if (n == 5)
    Console.WriteLine("Рабочий день: Пятница - IT'S FRIDAY!");
else if (n == 6)
    Console.WriteLine("Выходной день: Лучше Пятницы только Суббота!!!");
else
    Console.WriteLine("Выходной: Воскресенье!? Это лучшее, что можно было услышать с утра!");
