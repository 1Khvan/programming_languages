# Дана последовательность из N целых чисел и число K. 
# Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
# на K элементов вправо, K – положительное число.

list_numbers = [1,2,3,4,5,6,7,8]
print (list_numbers)
k= int(input("Введите число K: "))
for i in range(k):
    list_numbers.append(list_numbers[0])
    list_numbers.pop(0)
print (list_numbers)