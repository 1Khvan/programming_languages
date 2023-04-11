# Задача 12 Петя и Катя – брат и сестра. Петя – студент, а Катя – школьница. Петя
# помогает Кате по математике. Он задумывает два натуральных числа X и Y
# (X,Y≤1000), а Катя должна их отгадать. Для этого Петя делает две подсказки.
# Он называет сумму этих чисел S и их произведение P. Помогите Кате отгадать
# задуманные Петей числа.

sum_numbers = int(input("Введите сумму чисел: "))
multiplication_numbers = int(input("Введите произведение чисел: "))
y = int((sum_numbers + ((-sum_numbers) ** 2 - 4 * multiplication_numbers) ** 0.5) / 2)
x = int((sum_numbers - ((-sum_numbers) ** 2 - 4 * multiplication_numbers) ** 0.5) / 2)

if y>1000 or x>1000:
    print("Петя схитрил, загадданные числа больше 1000")
else:
    print(f"\nПетя загадал: {x} и {y}")

