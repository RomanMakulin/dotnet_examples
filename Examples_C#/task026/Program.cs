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
int Kolvo(int[] collection, int chet, int nechet)
{
    int number = 0;
    int number1 = 0;
    for (int index = 0; index < collection.Length; index++)
    {
        if (collection[index] % 2 == 0)
        {
            number++;
            chet = number;
        }
        else
        {
            number1++;
            nechet = number1;
        }
    }
    Console.WriteLine($"Количество четных элементов = {chet}. Нечетных = {nechet}");
    return number;
}

int chet = 0;
int nechet = 0;
int[] array = new int[6];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Kolvo(array, chet, nechet);

