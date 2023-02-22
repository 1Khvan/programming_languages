// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
                matrix[i, j, l] = new Random().Next(1, 11); // [1, 10]
        }

    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            Console.Write($"{matrix[i, j, l]} ({i},{j},{l}) \t");
        }  
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размер матриц: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1],size[2]];


InputMatrix(matrix);
PrintMatrix(matrix);