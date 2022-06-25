int[] array = {1, 73, 5, 23, 54, 73, 2, 76};
int n = array.Length;
int find = 73;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    };
    index = index + 1;
}