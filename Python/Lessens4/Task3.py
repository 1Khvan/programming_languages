# MAP
# C клавиатуры вводится некий набор чисел, в качетвет разделителя
# испоьзуется пробел. Этот набор чисел будет считан в качетве строки.
# Как превратить list строк в list чисел?

data = '15 156 96 3 5 8 52 5'
# print(data)

# data = data.split()
# print(data)

data = list(map(int, data.split()))
print(data)