// Найдём элемент, совпадающий с некоторым значением, который определяет пользователь

Console.Clear();

int[] array = { 1, 12, 31, 4, 15, 16, 17, 17, 18 };
int n = array.Length;

Console.Write("Введите число: ");
int find = Convert.ToInt32(Console.ReadLine());

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.Write($"Индекс: {index}");
        break;
    }
        //index = index + 1
        index++;
}
