
# Функция для сохранения файла
def save_file(phonebook):
    with open('Python\PhonebookFromGPT\phonebook.txt', 'w') as f:
        for name, number in phonebook.items():
            f.write(f'{name}:{number}n')

# Функция для показа телефонной книги
def show_phonebook(phonebook):
    for name, number in phonebook.items():
        print(f'{name}: {number}')

# Функция для добавления контакта
def add_contact(phonebook):
    name = input('Введите имя: ')
    number = input('Введите номер телефона: ')
    phonebook[name] = number
    print(f'{name} добавлен в телефонную книгу')

# Функция для поиска контакта
def find_contact(phonebook):
    name = input('Введите имя: ')
    if name in phonebook:
        print(f'{name}: {phonebook[name]}')
    else:
        print(f'{name} не найден в телефонной книге')

# Функция для изменения контакта
def edit_contact(phonebook):
    name = input('Введите имя: ')
    if name in phonebook:
        number = input('Введите новый номер телефона: ')
        phonebook[name] = number
        print(f'Номер телефона для {name} изменен')
    else:
        print(f'{name} не найден в телефонной книге')

# Функция для удаления контакта
def delete_contact(phonebook):
    name = input('Введите имя: ')
    if name in phonebook:
        del phonebook[name]
        print(f'{name} удален из телефонной книги')
    else:
        print(f'{name} не найден в телефонной книге')

# Основная функция
phonebook = 'Python\PhonebookFromGPT\phonebook.txt'
while True:
    print('Выберите действие:')
    print('1. Показать телефонную книгу')
    print('2. Добавить контакт')
    print('3. Найти контакт')
    print('4. Изменить контакт')
    print('5. Удалить контакт')
    print('6. Выход из программы')
    choice = input('Введите номер действия: ')
    if choice == '1':
        show_phonebook(phonebook)
    elif choice == '2':
        add_contact(phonebook)
    elif choice == '3':
        find_contact(phonebook)
    elif choice == '4':
        edit_contact(phonebook)
    elif choice == '5':
        delete_contact(phonebook)
    elif choice == '6':
        save_file(phonebook)
        break
    else:
        print('Неверный ввод, попробуйте еще раз')
