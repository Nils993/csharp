Console.Write("введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower ()== "Pavel")
{
    Console.WriteLine("Ура это Павел");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}