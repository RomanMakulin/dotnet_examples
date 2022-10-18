Console.WriteLine("54. В матрице чисел найти сумму элементов главной диагонали");
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}
int SumElDiag(int[,] array, int sum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, i];
    }
    System.Console.WriteLine($"{sum}");
    return sum;
}

int sum = 0;
int[,] array = new int[3, 3];
FillArray(array);
System.Console.WriteLine("Дана квадратная матрица: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Сумма диагонали элементов: ");
SumElDiag(array, sum);