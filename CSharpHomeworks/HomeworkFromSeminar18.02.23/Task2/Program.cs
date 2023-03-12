/*

Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

Console.WriteLine("Введите координаты A:");
int A1 = int.Parse(Console.ReadLine());
Console.WriteLine($"A({A1},*,*) B(*,*,*)-> ***");
int A2 = int.Parse(Console.ReadLine());
Console.WriteLine($"A({A1},{A2},*) B(*,*,*)-> ***");
int A3 = int.Parse(Console.ReadLine());
Console.WriteLine($"A({A1},{A2},{A3}) B(*,*,*)-> ***");

Console.WriteLine("Введите координаты B:");
int B1 = int.Parse(Console.ReadLine());
Console.WriteLine($"A({A1},{A2},{A3}) B({B1},*,*)-> ***");
int B2 = int.Parse(Console.ReadLine());
Console.WriteLine($"A({A1},{A2},{A3}) B({B1},{B2},*)-> ***");
int B3 = int.Parse(Console.ReadLine());

Double S = Math.Sqrt(Math.Pow(A1-B1,2)+Math.Pow(A2-B2,2)+Math.Pow(A3-B3,2));
Console.WriteLine($"A({A1},{A2},{A3}) B({B1},{B2},{B3})-> {S}");