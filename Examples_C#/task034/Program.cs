Console.WriteLine("42. Определить сколько чисел больше 0 введено с клавиатуры ");
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"Введите число под {i} индексом: ");
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) Console.Write("|" + collection[i]);
    Console.Write("|");
}
int Count(int[] collection, string text, int result)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 0)
        {
            result = result + 1;
        }
    }
    Console.WriteLine(text + result);
    return result;
}

int result = 0;
Console.Write("Введите количество элиментов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numbers];
FillArray(array);
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine();
Count(array, $"Количество элементов больше нуля = ", result);
