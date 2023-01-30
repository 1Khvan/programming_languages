// Task от [10 до 99]

Console.Clear();
int n = new Random().Next(10, 100); // [10, 99]
Console.WriteLine(n);
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2)
  Console.WriteLine(n1);
else
  Console.WriteLine(n2);
