Console.WriteLine("34. Написать программу замену элементов массива на противоположные");

void FillArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    while(index < count)
    {
        collection[index] = new Random().Next(-6, 6);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    Console.Write("Массив: ");
    while (index < count)
    {
        Console.Write("  " + collection[index]);
        index++;
    }
}
int Change(int[] collection, int number)
{
    int index = 0;
    int count = collection.Length;
    Console.Write("Противоположный массив: ");
    while (index < count)
    {
        number = collection[index] * -1;
        index++;
        Console.Write("  " + number);
    }
    return number;
}

int number = 1;
int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int number1 = Change(array, number);
