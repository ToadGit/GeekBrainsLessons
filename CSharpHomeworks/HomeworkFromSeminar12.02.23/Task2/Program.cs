/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"{a}");
int k = 0;
for (int i=a; i>-1;i/10)k++;
Console.WriteLine($"{k}");


//if (a<100)Console.WriteLine($"{a} -> третьей цифры нет");