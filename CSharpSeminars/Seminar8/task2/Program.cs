// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using System;
using static System.Console;

// Clear();
// Write("Введите N: ");
// int n=int.Parse(ReadLine());
// for (int i = 1; i <= n; i++){
//     Write($"{i} ");
// }
// WriteLine();
// WriteLine(PrintNumbers(n));
// _____________________________________

// string PrintNumbers(int m,int n){
//     if (n == 1) return "1";
//     string str = PrintNumbers(m,n - 1) + " " + n.ToString();
//     return str;
// }

// Write("Введите первое число:");
// int num1=int.Parse(ReadLine()!);

// Write("Введите второе число:");
// int num2=Convert.ToInt32(ReadLine());

// WriteLine($"Все числа в диапазоне ({num1}, {num2}) -> {PrintNumbers(num1, num2)}");

string PrintNumbers (int m, int n){
    if(n == m) return n.ToString();
    string str = PrintNumbers(m, n - 1) + " " + n.ToString();
    return str;
}

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int number2 = Convert.ToInt32(ReadLine());

WriteLine($"Все числа в диапазоне ({number1}, {number2}) -> {PrintNumbers(number1, number2)}");