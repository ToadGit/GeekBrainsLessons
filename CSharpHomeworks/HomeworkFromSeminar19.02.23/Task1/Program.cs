/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int arg()
{
Console.WriteLine("Введите число возводимое: ");
int A = int.Parse(Console.ReadLine()!);
return A;
}

int step()
{
    Console.WriteLine("Введите натуральную степень: ");
    int B = int.Parse(Console.ReadLine()!);
    while (B<0)
        {
        Console.WriteLine("Введите НАТУРАЛЬНУЮ степень: ");
        B = int.Parse(Console.ReadLine()!);
        }
    return B;
}

int a = arg();
int b = step();
Console.WriteLine($"{a},{b} -> {Math.Pow(a,b)}");