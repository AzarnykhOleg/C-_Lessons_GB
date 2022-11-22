Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "туся")
{
    Console.WriteLine("Ура!!! Это же ТУСЯ!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
