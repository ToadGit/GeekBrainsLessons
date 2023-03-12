/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/


int PropArr(string msg)
{
   Console.WriteLine(msg);
   int res = int.Parse(Console.ReadLine());
   return res;
} 

void PrintArr(int[] arr)
{
    Console.Write("[ ");
    for (int i=0 ;i<arr.Length - 1 ;i++)
    {
    Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]} ]");
}

int[] ArrMake(int length)
{
    int [] a = new int[length];
    for (int i = 0; i<length;i++)
    {
        a[i] = new Random().Next(1,10);
    }
    return a;
}

int length = PropArr("Введите длинну массива: ");
int[] array = ArrMake(length);
PrintArr(array);