Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "вадим")
{
    Console.WriteLine("Здравствуй, мой любимый Вадим");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}