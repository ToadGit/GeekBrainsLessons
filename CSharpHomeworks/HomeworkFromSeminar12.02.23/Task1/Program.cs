/*
Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру 
этого числа.
456 -> 5 
782 -> 8 
918 -> 1


Console.WriteLine(true ^ true);    // output: False
Console.WriteLine(true ^ false);   // output: True
Console.WriteLine(false ^ true);   // output: True
Console.WriteLine(false ^ false);  // output: False


*/
Console.Clear();
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
//
while (n <-999 || (n >-100 && n<100) || n >999)
//while (n<100||n>999)
{
Console.WriteLine("Введите трехзначное число:");
n = int.Parse(Console.ReadLine());
}
Console.WriteLine($"{n} -> {Math.Abs((n/10)%10)}");


//n<-999 ИЛИ (n>-100 И n<100)  ИЛИ n>999