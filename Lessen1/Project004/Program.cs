Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

 if(username.ToLower () == "елена")
 {
    Console.WriteLine("Ура, это же Елена!");
 }
 else
 {
    Console.Write("Привет, ");
    Console.WriteLine(username);
 }