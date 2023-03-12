void FillArray(int[] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
{
    collection[index] = new Random().Next(1, 10);
    index++;
}
}

void PrindArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int[] array = new int[10];

int IndexOf(int[] biba,int find)
{
    int count = biba.Length;
    int index = 0;
    int pos = -1;

    while (index<count)
    {
        if (biba[index] == find)
        {
            pos = index;
            break;
        }
        index++;
    }
    return pos;
}

FillArray(array);
PrindArray(array);
Console.WriteLine("---------------------");

int bip = IndexOf(array, 4);
if (bip== -1) Console.WriteLine("Искомого числа в массиве нет");
else 
Console.WriteLine($"Index = {bip}");