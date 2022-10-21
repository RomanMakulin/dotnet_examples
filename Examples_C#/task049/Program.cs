// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 3);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($"{array[i, j]} \t");
        System.Console.WriteLine();
    }
}
void MaxSumString(int[,] array)
{
    int[] ArrayString = new int[array.GetLength(1)];
    int min = ArrayString[0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        ArrayString[i] = sum;
        }
        for (int k = 0; k < ArrayString.Length; k++)
    System.Console.WriteLine(sum);
    }
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
MaxSumString(array);