// Проверить частоту элементов массива

System.Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = int.Parse(Console.ReadLine());
}
int[] PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) System.Console.Write($"{collection[i]} \t");
    return collection;
}

void Freq(int[] collection, int count)
{
    for (int i = 0; i < collection.Length; i++)
    {
        for (int k = i + 1; k < collection.Length; k++)
        {
            if (collection[i] != )
            if (collection[i] == collection[k])
            {
                count = count + 1;
                if (collection[i] == collection[k+1])
                {
                    count = count + 1;
                }
            }
        }
        System.Console.WriteLine($"Число {collection[i]} повторяется {count} раз ");
    }
}
int count = 0;
System.Console.WriteLine("Введите элементы массива: ");
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Freq(array, count);