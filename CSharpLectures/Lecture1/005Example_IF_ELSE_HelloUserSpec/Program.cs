Console.Write("Введите ваше имя ");
string username = Console.ReadLine();
if (username.ToLower() == "миша")// .ToLower - перевод символов в нижний геристр
{
Console.WriteLine("Ура, это же Миша");
}
 else
 {
 Console.Write("Привет, ");
 Console.WriteLine(username);
 }