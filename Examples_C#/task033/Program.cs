Console.WriteLine("40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом");
// 40. В Указанном массиве вещественных чисел найдите 
// разницу между максимальным и минимальным элементом.

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"Введите массив под индексом {i}: ");
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] collection)
{
    Console.Write("Массив: ");
    for (int i = 0; i < collection.Length; i++) Console.Write("\t" + collection[i]);
}
int DiffMaxMin(int[] collection, int max, int min, int result)
{
    max = collection[0]; min = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > max)
        {
            max = collection[i];
        }
        if (collection[i] < min)
        {
            min = collection[i];
        }
    }
    Console.WriteLine($"Максимальное значение массива = {max}");
    Console.WriteLine($"Минимальное значение массива = {min}");
    Console.WriteLine($"Разница между ними = {result = max - min}");
    return result;
}

int result = 0;
int max = 0, min = 0;
int[] array = new int[6];
FillArray(array);
PrintArray(array);
Console.WriteLine();
DiffMaxMin(array, max, min, result);
