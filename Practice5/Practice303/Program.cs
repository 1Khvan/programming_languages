// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76

Console.Clear();

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

int min = array[0];
int max = 0;

foreach (int element in array)
{
    if (element > max)
        max = element;
    if (element < min)
        min = element;

}
Console.WriteLine($"Максимальное число массива: {max}");
Console.WriteLine($"Минимальное число массива: {min}");
Console.WriteLine($"Разница между этими элементами: {max - min}");