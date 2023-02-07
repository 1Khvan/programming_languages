// ЗАДАЧА №496 В фермерском хозяйстве в Карелии выращивают чернику. 
// Она растет на круглой грядке, причем кусты высажены только по окружности. 
// Таким образом, у каждого куста есть ровно два соседних. Всего на грядке растет N кустов.
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=113&id_problem=695

Console.Clear();
Console.Write("Введите количество кустов черники, а затем количество ягод, растущее на соответствующем кусте: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"[{string.Join(", ", array)}]");

int maxSum = 0;
for (int i = 1; i < array.Length - 1; i++)
{
    int sum = array[i - 1] + array[i] + array[i + 1];
    if (sum > maxSum)
        maxSum = sum;
}
if (array[0] + array[1] + array[array.Length - 1] > maxSum)
    maxSum = array[0] + array[1] + array[array.Length - 1];
if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSum)
    maxSum = array[array.Length - 1] + array[array.Length - 2] + array[0];

Console.WriteLine(maxSum);