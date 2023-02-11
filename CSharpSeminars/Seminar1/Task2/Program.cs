/* 
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет
*/

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int sqr = Convert.ToInt32(Math.Pow(b,2));//32 чето про память на число
Console.WriteLine($"Квадрат числа {b} -> {sqr}");

Console.WriteLine("Проверка ...");

if (sqr==a)
{
Console.WriteLine($"a = {a}; b = {b} -> да");
}
else
{
Console.WriteLine($"a = {a}; b = {b} -> нет");
}