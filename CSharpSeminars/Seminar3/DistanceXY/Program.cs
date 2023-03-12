// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.WriteLine("Введите коодлинаты A:");
int A1 = int.Parse(Console.ReadLine());
Console.WriteLine($"A({A1},*) B(*,*)-> ***");
int A2 = int.Parse(Console.ReadLine());
Console.WriteLine($"A({A1},{A2}) B(*,*)-> ***");
Console.WriteLine("Введите коодлинаты B:");
int B1 = int.Parse(Console.ReadLine());
Console.WriteLine($"A({A1},{A2}) B({B1},*)-> ***");
int B2 = int.Parse(Console.ReadLine());
Double S = Math.Sqrt(Math.Pow(A1-B1,2)+Math.Pow(A2-B2,2));
Console.WriteLine($"A({A1},{A2}) B({B1},{B2})-> {S}");
