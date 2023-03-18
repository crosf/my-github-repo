int[] array = { 1, 2, 6, 78, 62, 35, 56, 62 };

int  n = array.Length;
int find = 62;

int index =0;

while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}