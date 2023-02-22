// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размер матриц: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[,] matrix2 = new int[size[0], size[1]];
int[,] matrixMultiplication = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
InputMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrixMultiplication[i, j] = 0;
        {
            matrixMultiplication[i, j] += matrix[i, j] * matrix2[i, j];
        }
    }
}

Console.WriteLine("Результирующая матрица будет: ");
PrintMatrix(matrixMultiplication);
