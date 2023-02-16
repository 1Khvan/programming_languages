﻿// ЗАДАЧА №323 Известно, что любое чётное число, большее 2, 
// представимо в виде суммы 2 простых чисел, причём таких разложений может быть несколько. 
// Впервые гипотезу о существовании данного разложения сформулировал математик Х. Гольдбах.

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int countDel = 0, i, j, k, m;
for (i = 2; i <= n / 2; i++)
{
    countDel = 0;
    for (j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
            countDel++;
    }
    if (countDel == 0)
    {
        countDel = 0;
        m = n - i;
        for (k = 2; k <= (m + 1) / 2; k++)
        {
            if (m % k == 0)
                countDel++;
        }
        if (countDel == 0)
        {
            Console.WriteLine($"{i} {m}");
            return;
        }
    }
}