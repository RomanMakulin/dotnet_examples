// Найти индекс числа 4.
int[] array = {41, 22, 3, 4, 5, 16};

int n = array.Length;
int index = 0;
int find = 4;

while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
    }
    index++;

}

