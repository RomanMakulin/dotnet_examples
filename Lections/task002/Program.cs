void FillArray(int[] collection) //Заполняем новый массив
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
    collection[index] = new Random().Next(1, 10);
     index++;   
    }
}

void PrintArray(int[] col) // Печатаем новый массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // Находим позицию числа
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // новый массив 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);