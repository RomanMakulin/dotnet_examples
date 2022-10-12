Console.WriteLine("39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.");
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(0, 5);
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) Console.Write(" " + collection[i]);
}
int Method(int[] collection, int result)
{
    int i2 = collection.Length - 1;
    for (int i = 0; i < i2; i++)
    {
        if (i < collection.Length)
        {
            result = collection[i] * collection[i2];
            i2 -= 1;
            Console.WriteLine($"Произведение пары чисел = {result}");
        }
    }
    return result;
}

int result = 0;
int[] array = new int[9];
Console.Write("Массив: ");
FillArray(array);
PrintArray(array);
Console.WriteLine();
Method(array, result);