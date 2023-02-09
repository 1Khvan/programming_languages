// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = new int[3];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int count = 0;

foreach (int element in array)
{
    if (element % 2 != 0)
        count += element;
}      
Console.WriteLine($"Количетво чётных чисел: {count}");
