# Задача 16: Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X

# *Пример:*
# N=5
# A[1, 2, 3, 4, 5,]
# X=3
# -> 1

import random
number_item = int(input("Введите количество элементов в массиве: "))
array = [random.randint(1, 100) for i in range(number_item)]
print(array)
found_number = int(input("Введите число: "))
count = 0
i=0
if array[i] == found_number:
    count += 1
    print(f"Ваше число встретилось: {count} раз")
else:
    print("Некорректный ввод. Попробуйте еще раз!")
