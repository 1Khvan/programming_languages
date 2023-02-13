// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();
int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10); // [-9; 9]
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int sumNegative = 0, sumPositive = 0;
foreach(int element in array)
{
    if (element > 0)
        sumPositive += element;
    else
        sumNegative += element;
}
Console.WriteLine($"Сумма положительных чисел {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел {sumNegative}");