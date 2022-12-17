using static System.Console;
Clear();

int[] array = {1, 12, 31, 4, 15, 16, 17, 18};
int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        WriteLine(index);
        break;
    }

    index++;
}