// ЗАДАЧА №1214 Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].

Console.Clear();

int[] array = { 1, 2, 3, 4, 5 };
Console.Write("Введите искомое число: ");
int c = Convert.ToInt32 (Console.ReadLine());
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]==c)
    count++;
}

Console.WriteLine(count);


// Console.Write("Введите количество элементов в массиве: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[a];

// Console.Write("Введите элементы массива: ");
// int b = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < b; i++)
// {

// }



// Console.Write("Введите искомое число: ");
// int c = Convert.ToInt32 (Console.ReadLine());
// int count = 0;

// for (int i = 1; i < array.Length; i++)
// {
//     if (b[i]==c)
//     count++;
// }

// Console.WriteLine(count);