﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 10);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    count ++;
}
Console.WriteLine($"Чисел больше ноля: {count}");