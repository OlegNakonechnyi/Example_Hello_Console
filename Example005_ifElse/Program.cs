Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

switch (username.ToLower())
{
    case "катя":
        Console.Write("Ура, это же Катя!");
        break;
    default:
        Console.Write("Привет, ");
        Console.WriteLine(username);
        break;
} 