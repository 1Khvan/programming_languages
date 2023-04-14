# Дан список, состоящий из целых чисел. Напишите программу, 
# которая подсчитает количество элементов списка, больших 
# предыдущего (элемента с предыдущим номером)

list_numbers = [1,2,3,4,5,6,7,8]
k=len(list_numbers)-1
count=0
for i in range(k):
    if list_numbers[i]<list_numbers[i+1]:
        count+=1
print(count)
