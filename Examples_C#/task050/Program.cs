System.Console.WriteLine("60. Составить частотный словарь элементов двумерного массива");
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 7);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($"{array[i, j]}  ");
        System.Console.WriteLine();
    }
}
int[] ToOneMassiv(int[,] array)
{
    int[] newArr = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArr[i] = array[i, j];
            System.Console.Write($"{newArr[i]}  ");
        }
    }
    return newArr;
}
void Frequency(int[] OneMassiv)
{
    int m = 1;
    int[] NewArray = new int[OneMassiv.Length];
    for (int i = 0; i < OneMassiv.Length; i++)
    {
        for (int k = i + 1; k < OneMassiv.Length; k++)
        {
            if (OneMassiv[i] == OneMassiv[k])
            {
                m = m + 1;
                System.Console.WriteLine($"кол-во повторений числа {OneMassiv[i]}: {m}");
            }
            else
            {
                System.Console.WriteLine($"кол-во повторений числа {OneMassiv[i]}: {m}");
            }
        }
    }
}

System.Console.Write("Введите размер массива (количество рядов): ");
int sizeA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите размер массива (количество столбцов): ");
int sizeB = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[sizeA, sizeB];
int[] newArr = new int[array.GetLength(0) * array.GetLength(1)];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ToOneMassiv(array);
System.Console.WriteLine();
Frequency(ToOneMassiv(array));