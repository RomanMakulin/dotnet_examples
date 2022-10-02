void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write("  ");
        position++;
    }
}



int[] array = new int [10];

Console.WriteLine("Новый заданный массив из 10 чисел:");
FillArray(array);
PrintArray(array);
