/*
// На столе лежат n монеток. Некоторые из них лежат вверх решкой, 
// а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть, 
// чтобы все монетки были повернуты вверх одной и той же стороной.
*/

int Ptemp =0;
int Ntemp =0;
Console.WriteLine("Сколько монеток?");
int mon = int.Parse(Console.ReadLine());
int[] a = new int[mon];

for (int i = 0; i < mon;i++) a[i] = new Random().Next(0, 2);

Console.WriteLine("Вот ваши монетки(1-решка):");
for (int i = 0; i < mon; i++)Console.Write($"{a[i]} ");


for (int i = 0; i < mon; i++)
{
    if (a[i]==0)Ntemp++;
    else Ptemp++;
}

if (Ptemp>Ntemp)Console.WriteLine($"переверни орлы {Ntemp} раз"); 
else Console.WriteLine($"переверни решки {Ptemp} раз"); 
