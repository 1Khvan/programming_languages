// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int[] resultArray = new int[n / 2 + n % 2];
for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = array[i] * array[array.Length - 1 - i];
}
Console.WriteLine($"Конечный массив: [{string.Join(", ", resultArray)}]");