Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
        Console.WriteLine("Ura, eto zhe MASHA");
}
else
{
        Console.Write("Привет, ");
        Console.WriteLine(username);
}