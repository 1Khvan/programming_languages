# LAMDA
# В писке храняться числа. Нужно выбрать только четные числа и составить список пар (число; квадрат числа)
# Например: 123458152338
# Ответ: [(2,4), (8,64), (38,1444)]

# Вариант 1
# list_numbers = [1, 2, 3, 4, 5, 8, 15, 23, 38]
# result = list()
# for i in list_numbers:
#     if i % 2 == 0:
#         result.append((i,i**2))
# print(result)

# ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
# Вариант2
# def select(f, col):
#     return [f(x) for x in col]

# def where(f, col):
#     return [x for x in col if f(x)]


# list_numbers = [1, 2, 3, 4, 5, 8, 15, 23, 38]
# result = select(int, list_numbers)
# print(result)
# result = where(lambda x: x % 2 == 0, result)
# print(result)
# result = list(select(lambda x: (x, x**2), result))
# print(result)

# ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
# Вариант3
# def where(f, col):
#     return [x for x in col if f(x)]

# list_numbers = [1, 2, 3, 4, 5, 8, 15, 23, 38]
# result = map(int, list_numbers)

# result = where(lambda x: x % 2 == 0, result)
# print(result)
# result = list(map(lambda x: (x, x**2), result))
# print(result)

# ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
# Вариант4
list_numbers = [1, 2, 3, 4, 5, 8, 15, 23, 38]
result = map(int, list_numbers)
result = filter(lambda x: x % 2 == 0, result)
result = list(map(lambda x: (x, x**2), result))
print(result)