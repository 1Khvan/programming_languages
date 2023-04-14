# Задача 18: Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X. 
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве. 
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
# *Пример:*
# N=5
# A[1, 2, 3, 4, 5]
# Х=6
# -> 5

import random
number_item = int(input("Введите количество элементов в массиве: "))
array = [
    random.randint(1, 100) 
    for i in range(number_item)
    ]
print(array)
found_number = int(input("Введите число: "))


index_element = 0
min_element = abs(found_number - array[0])
for i in range(1, number_item):
    buffer_element = abs(found_number -array[i])
    if buffer_element < min_element:
        min_element = buffer_element
        index_element = i

print(f"Самый близкий по величине элемент к заданному числу {array[index_element]}")


