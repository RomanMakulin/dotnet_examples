Console.WriteLine("31. Задать массив из 8 элементов и вывести их на экран ");
// + 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран (+)

void FillArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    while (index < count)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    Console.Write("Заданный массив: ");
    while (index < count)
    {
        Console.Write("  " + collection[index]);
        index++;
    }
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);