// Условнные группы методов
Console.Clear();

// Первая группа

void Metod1()
{
Console.WriteLine("Автор …");
}

// Вторая группа

void Metod2(string msg) //— где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.
{
    Console.WriteLine(msg); // — оператор, в скобках указан принятый аргумент.
}

// Именнуемые Аргументы

void Metod21(string msg, int count)
{
	int i = 0;
	while (i < count)
	{
	Console.WriteLine(msg);// - где переменная count отображает на экране определённое количество сообщений msg.
	i++;
	}
}

// Третья группа

int Metod3() // - не принимает никакие аргументы
{
return DateTime.Now.Year; //- обязательное использование оператора return,
}
int year = Metod3(); //- вызываем метод, в левой части используем идентификатор переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);

// Четвертая группа Самая важная группа методов, это методы, которые что-то принимают и что-то возвращают.

string Metod4(int count, string text)
{
	int i = 0;
	string result = String.Empty;
	while (i<count)
		{
		result = result + text;
		i++;
		}
	return result;
}
string res = Metod4(10, "metod");
Console.WriteLine(res);

//Цикл “for” в методе

string Metod41(int count, string text) 
{
	string result = String.Empty;
		for (int i = 0; i<count; i++)// - вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент (увеличение счётчика).
		{
	result = result + text;
}
return result; }
res = Metod41(10, "metod"); Console.WriteLine(res);

