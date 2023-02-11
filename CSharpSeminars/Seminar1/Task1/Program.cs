/**Задача 0:** 

**Условие:**

Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

**Например:**

4 -> 16
-3 -> 9
-7 -> 49
*/

Console.Clear();
Console.WriteLine("Введите число возводимое в квадрат: ");
int number = int.Parse(Console.ReadLine());
int sqr = number*number;
Console.WriteLine($"Квадрат числа {number} number -> {sqr}({number*number})");
int sqr1 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"Квадрат числа {number} -> {sqr1}");