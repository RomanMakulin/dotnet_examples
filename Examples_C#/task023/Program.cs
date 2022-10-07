Console.WriteLine("33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива");
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    while(index < count)
    {
        collection[index] = new Random().Next(0,10);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    Console.Write("Массив: ");
    while(index < count)
    {
        Console.Write("  " + collection[index]);
        index++;
    }
}
int Sum(int[] collection, int number, int number2)
{
    int index = 0;
    int count = collection.Length;
    while(index < count)
    {
        if (collection[index] % 2 == 0)
        {
           number += collection[index];
           index++;
        }
        else
        {
            number2 += collection[index];
            index++;
        }
    }
    Console.WriteLine($"Сумма четных элементов массива: {number}");
    Console.WriteLine($"Сумма не четных элементов массива: {number2}");
    return number;
}

int number = 0;
int number2 = 0;
int[] array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int numberAll = Sum(array, number, number2);