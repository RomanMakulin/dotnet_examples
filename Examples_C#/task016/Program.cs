Console.WriteLine("25. Найти сумму чисел от 1 до А.");

void FillArray(int[]collection) // Заполнили массив
{
    int count = collection.Length;
    int index = 0;
    while (index < count)
    {
        collection[index] = new Random().Next(1,4);
        index++;
    }
}

void PrintArray(int[] collection) // Печатаем массив
{
    int count = collection.Length;
    int index = 0;
    Console.Write("Массив: ");
    while (index < count)
    {
        Console.Write("  "+ collection[index]);
    index++;
    }
}

int Math(int[] collection, int sum)
{
    int index = 0;
    sum = 0;
    int count = collection.Length;

    while (index < count)
    {
        sum += collection[index];
        index++;
    }
    return sum;
}
int sum = 0;
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int sum1 = Math(array, sum);
Console.WriteLine($"Сумма элементов массива = {sum1}");
