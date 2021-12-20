Console.Write("Введи имя: ");

string username = Console.ReadLine();

if(username.ToLower() == "саша")
{
    Console.WriteLine("Ура, это же САШКА!");  
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}