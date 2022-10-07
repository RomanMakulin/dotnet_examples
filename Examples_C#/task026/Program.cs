Console.WriteLine("36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных/четных чисел");
//36. Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

void FillArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    while (index < count)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    while (index < count)
    {
        Console.Write("  " + collection[index]);
        index++;
    }
}
int KolVo(int[] collection, int chet, int nechet)
{
    int index = 0;
    int count = collection.Length;
    while (index < count)
    {
        if (collection[index] % 2 == 0)
        {
            chet += index;
            index++;
        }
        else
        {
            nechet += index;
            index++;
        }
    }
    Console.WriteLine($"Количество четных элементов: {chet} ");
    Console.WriteLine($"Количество не четных элементов: {nechet} ");
    return chet;
}
int chet = 0;
int nechet = 0;
int[] array = new int[3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
KolVo(array, chet, nechet);
