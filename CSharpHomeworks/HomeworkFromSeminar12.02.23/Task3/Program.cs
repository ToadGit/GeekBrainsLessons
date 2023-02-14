/*
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день 
выходным.

6 -> да 7 -> да 1 -> нет
*/

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int nDay = int.Parse(Console.ReadLine());//строка в число
if (nDay>0&&nDay<6)Console.WriteLine($"{nDay}-> нет");
else if (nDay>5&&nDay<8)Console.WriteLine($"{nDay}-> да");
else Console.WriteLine($"Ошибка выбора дня недели");