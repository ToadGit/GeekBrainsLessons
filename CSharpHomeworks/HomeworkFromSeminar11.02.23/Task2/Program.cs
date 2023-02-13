/*
Задача 4: Напишите программу, которая принимает на 
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
//программа поинтереснее:
int temp=0,max=0;
Console.WriteLine("Ну че, сколько чисел проверим?(Будь добр, уложись в диапозон от 0 до 18.446.744.073.709.551.615 чисел)");
//string c = Console.ReadLine();
ulong a = ulong.Parse(Console.ReadLine());
//ulong a = ulong.Parse(Console.ReadLine());
for (ulong i = 0 ; i < a ; i++)
{
    Console.WriteLine($"Введите {i+1} число: ");
    temp=int.Parse(Console.ReadLine());
    if (temp>max)
    {
    max=temp;
    }
}
Console.WriteLine($"{max} -> максимальное число");