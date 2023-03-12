/*

найти индекс соответств по значению элементу в массиве

*/

int[] array={2,6,84,9,5,3,4,7};

int n = array.Length;
int find = 4;

int index = 0;


while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index+1);
    }
    index++;
}
