/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int Summ(int a)
{
    int k=0;
    while (a/10!=0)
    {
        k=k+(a%10);
        a=a/10;
    }
    k=k+a;
    return k;
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int result = Summ(n);
Console.WriteLine($"{n} -> {result} ");

