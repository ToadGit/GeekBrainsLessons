// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int[] array = new int[a];
double d = 0;
Console.Write($"{a} -> ");
for (int i = 0; i < a;i++) 
{array[i] = i+1;
d = Math.Pow(array[i],2);
Console.Write($"{d} ");
}