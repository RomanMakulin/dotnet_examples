Console.WriteLine("38. Найти сумму чисел одномерного массива стоящих на нечетной позиции");
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(0, 5);
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) Console.Write("\t" + collection[i]);
}
int SumNechet(int[] collection, string text, int sum)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 != 0)
        {
            sum = collection[i] + sum;
        }
    }
    Console.WriteLine(text + sum);
    return sum;
}

int sum = 0;
int[] array = new int[5];
Console.Write("Массив: ");
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumNechet(array, "Сумма чисел на нечетной позиции = ", sum);