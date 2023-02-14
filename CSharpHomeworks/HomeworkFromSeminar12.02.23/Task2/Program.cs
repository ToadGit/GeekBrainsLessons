/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
int temp = a;
int ch = 0;
    if (a<100)
{
    Console.WriteLine($"{a} -> третьей цифры нет");
    return;
}
    else
{
    for (int i=0;temp>0;i++)
    {
        temp=temp/10;
        ch=i+1;
    }
    Console.WriteLine($"{ch}");
    if (ch==3)Console.WriteLine($"{a} -> {a%10}");
    else
    {
    int num_n = 1;
    for(int i=0; i<ch-3; i++)num_n*=10;
    Console.WriteLine($"{a} -> {(a/num_n)%10}");
    }
}