Console.WriteLine("35. Определить, присутствует ли в заданном массиве, некоторое число");

void FillArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    while(index < count)
    {
        collection[index] = new Random().Next(0,4);
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
int FindNumber(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int Find(int[] collection, int FindN)
{
    int index = 0;
    int count = collection.Length;
    int find = -1;
    while(index < count)
    {
    if (collection[index] == FindN)
    {
        find = collection[index];   
    }
        index++;
    }
        Console.WriteLine($"Число {find} присутствует в массиве");
    return find;
}

int[] array = new int[6];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int number = FindNumber("Введите число: ");
Find(array, number);