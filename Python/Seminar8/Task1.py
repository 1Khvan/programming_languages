# Создать телефонный справочник с возможностью импорта и экспорта данных в формате .txt.
# Фамилия, имя, отчество, номер телефона - данные, которые должны находиться в файле.
# 1. Программа должна выводить данные
# 2. Программа должна сохранять данные в текстовом файле
# 3. Пользователь может ввести одну из характеристик для поиска определенной записи(Например имя или фамилию человека)
# 4. Использование функций. Ваша программа не должна быть линейной

# Функционал:
# 1. Открыть файл
# 2. Сохранить файл
# 3. Показать телефонную книгу
# 4. Добавить контакт
# 5. Найти контакт
# 6. Изменить контакт
# 7. Удалить контакт
# 8. Выход из программы


import os
def clear(): return os.system('cls')
clear()

# Посмотреть список контактов
def contact_list():
    with open('Python\Seminar8\PhoneBook.txt', 'r', encoding='utf-8') as file:
        book = file.read()
    return book

# Добавить контакт
def add_contact():
    with open('Python\Seminar8\PhoneBook.txt', 'r+', encoding='utf-8') as file:
        record_id = 0
        for line in file:
            if line != '':
                record_id = line.split(';', 1)[0]
        print('Введите фамилию, имя, отчество, номер телефона через пробел')
        line = f'{int(record_id) + 1};' + ';'.join(input().split()[:4]) + ';\n'
        file.write(line)

# Найти контакт
def find_char():
    print('Выберите характеристику:')
    option=('0 - id, 1 - фамилия, 2 - имя, 3 - отчество, 4 - номер, q - выйти')
    print(option)
    char = input()
    while char not in ('0', '1', '2', '3', '4', 'q'):
        print('Введены неверные данные')
        print('Выберите характеристику:')
        print(option)
        char = input()
    if char != 'q':
        inp = input('Введите значение\n')
        return char, inp
    else:
        return 'q', 'q'
    
def find_contact(char, condition):
    if condition != 'q':
        printed = False
        with open('Python\Seminar8\PhoneBook.txt', 'r', encoding='utf-8') as data:
            for line in data:
                if condition == line.split(';')[int(char)]:
                    print(*line.split(';'))
                    printed = True
        if not printed:
            print("Не найдено")
        return printed

# Изменить контакт
def change_contact(new_data, old_data):
    contacts = contact_list()
    with open('Python\Seminar8\PhoneBook.txt', 'a', encoding='utf8') as file:
        for item in contacts:
            if  old_data != item:
                file.write(item)
            else:
                file.write(new_data + "\n")

# Удалить контакт
def delete_person(name):
    contacts = contact_list()
    with open('Python\Seminar8\PhoneBook.txt', 'a', encoding='utf8' ) as file:
        for item in contacts:
            if name != item:
                file.write(item)

print("ТЕЛЕФОННЫЙ СПРАВОЧНИК")
print("Выберите команду: ")
print("1: Посмотреть список контактов")
print("2: Добавить контакт")
print("3: Найти контакт")
print("4: Изменить контакт")
print("5: Удалить контакт")
print("6: Выход")
while True:
    fromUser = int(input("Ваш выбор: "))
    if fromUser == 1:
        print(contact_list())
    elif fromUser == 2:
        add_contact()
    elif fromUser == 3:
        find_contact('Python\Seminar8\PhoneBook.txt', *find_char())
    elif fromUser == 4:
        old_data = input('Чей контакт хотим изменить?: ')
        new_data = input('Как хотим изменить?: ')
        change_contact(new_data,old_data)
    elif fromUser == 5:
        name = input('Чей контакт хотим удалить?: ')
        delete_person(name)
    elif fromUser == 6:
        break
    else:
        print("Выбрана не корректная команда")



