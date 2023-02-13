/* 11 Напишите программу, которая выводит случайное 
трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 */

// 7 задача - %10 просто

Console.Clear();
int num = new Random().Next(100,999);
int Beg = num /100;
int Back = num %10;

Console.WriteLine($"{num} -> {Beg}{Back}");
// Console.WriteLine($"{num} -> {num /100}{num %10}");