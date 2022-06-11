int[] array = {1,2,73,43,5,6,78,78,};

int n = array.Length;

int find = 78;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}