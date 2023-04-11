# Задача 10: На столе лежат n монеток. Некоторые из них лежат вверх решкой, а некоторые – гербом. 
# Определите минимальное число монеток, которые нужно перевернуть, чтобы все монетки были повернуты 
# вверх одной и той же стороной. Выведите минимальное количество монет, которые нужно перевернуть

import random
number_of_coins = int(input("Введите количетво монет: "))
number_of_sides = 0
count_zero = 0
count_one = 0

for i in range(number_of_coins):
    number_of_sides=random.randint(0, 1)
    print (number_of_sides, end=" ")
    if number_of_sides == 0:
        count_zero += 1
    else:
        count_one += 1
if count_one > count_zero:
    print(f"\nМинимальное количество монет, которые нужно перевернуть: {count_zero}")
else:
    print(f"\nМинимальное количество монет, которые нужно перевернуть: {count_one}")
