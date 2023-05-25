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
def find_сharacteristic():
    print('Выберите характеристику:')
    option=('0 - id, 1 - фамилия, 2 - имя, 3 - отчество, 4 - номер, q - выйти')
    print(option)
    сharacteristic = input()
    while сharacteristic not in ('0', '1', '2', '3', '4', 'q'):
        print('Введены неверные данные')
        print('Выберите характеристику:')
        print(option)
        сharacteristic = input()
    if сharacteristic != 'q':
        fromUser = input('Введите значение\n')
        return сharacteristic, fromUser
    else:
        return 'q', 'q'
    
def find_contact(file_name: str, сharacteristic, condition):
    if condition != 'q':
        printed = False
        with open(file_name, 'r', encoding='utf-8') as file:
            for line in file:
                if condition == line.split(';')[int(сharacteristic)]:
                    print(*line.split(';'))
                    printed = True
        if not printed:
            print("Не найдено")
        return printed



def check_id_contact(file_name: str, text: str):
    decision = input(f'Вы знаете id записи которую хотите {text}? 1 - да, 2 - нет, q - выйти\n')
    while decision not in ('1', 'q'):
        if decision != '2':
            print('Введены неверные данные')
        else:
            find_contact('Python\Seminar8\PhoneBook.txt', *find_сharacteristic())
        decision = input(f'Вы знаете id записи которую хотите {text}? 1 - да, 2 - нет, q - выйти\n')
    if decision == '1':
        record_id = input('Введите id, q - выйти\n')
        while not find_contact(file_name, '0', record_id) and record_id != 'q':
            record_id = input('Введите id, q - выйти\n')
        return record_id
    return decision

def confirmation(text: str):
    confirm = input(f"Подтвердите {text} записи: 1 - да, 2 - нет\n")
    while confirm not in ('1', '2'):
        print('Введены неверные данные')
        confirm = input(f"Подтвердите {text} записи: 1 - да, 2 - нет\n")
    return confirm

def replace_contact_line(file_name: str, record_id, replaced_line: str):
    replaced = ''
    with open(file_name, 'r', encoding='utf-8') as file:
        for line in file:
            replaced += line
            if record_id == line.split(';', 1)[0]:
                replaced = replaced.replace(line, replaced_line)
    with open(file_name, 'w', encoding='utf-8') as file:
        file.write(replaced)

# Изменить контакт
def change_contact(file_name: str):
    record_id = check_id_contact(file_name, 'изменить')
    if record_id != 'q':
        replaced_line = f'{int(record_id)};' + ';'.join(
            input('Введите фамилию, имя, отчество, номер телефона через пробел\n').split()[:4]) + ';\n'
        confirm = confirmation('изменение')
        if confirm == 'y':
            replace_contact_line(file_name, record_id, replaced_line)

# Удалить контакт
def delete_records(file_name: str):
    record_id = check_id_contact(file_name, 'удалить')
    if record_id != 'q':
        confirm = confirmation('удаление')
        if confirm == 'y':
            replace_contact_line(file_name, record_id, '')




print("Основное меню")
print("Выберите команду: ")
print("1: Посмотреть список контактов")
print("2: Добавить контакт")
print("3: Найти контакт")
print("4: Изменить контакт")
print("5: Удалить контакт")
print("6: Выход")
while True:
    fromUser = int(input("Ваш выбор из основого меню: "))
    if fromUser == 1:
        print(contact_list())
    elif fromUser == 2:
        add_contact()
    elif fromUser == 3:
        find_contact('Python\Seminar8\PhoneBook.txt', *find_сharacteristic())
    elif fromUser == 4:
        change_contact('Python\Seminar8\PhoneBook.txt')
    elif fromUser == 5:
        delete_records('Python\Seminar8\PhoneBook.txt')
    elif fromUser == 6:
        break
    else:
        print("Выбрана не корректная команда")



