Console.WriteLine("55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");
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
double[] SrArifm(int[,] array)
{
    double[] OneArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        OneArray[j] = sum / array.GetLength(0);
        System.Console.WriteLine($"{OneArray[j]} \t");
    }
    return OneArray;
}

int[,] array = new int[4, 6];
FillArray(array);
System.Console.WriteLine("Матрица: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Среднее арифм столбцов: ");
SrArifm(array);
