/*
7. Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает последнюю цифру этого числа.

456 -> 6

782 -> 2

918 -> 8
*/
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
while (a <-999 || (a >-100 && a<100) || a >999)
{
Console.WriteLine("Введите трехзначное число:");
a = int.Parse(Console.ReadLine());
}
Console.WriteLine($"{a} -> {Math.Abs(a%10)}");
