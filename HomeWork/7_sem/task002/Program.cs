// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 8);
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
double[] SrArifmColumns(int[,] array)
{
    double sum = 0;
    double[] Columns = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Columns[j] = sum / array.GetLength(0);
        System.Console.Write($"[{Columns[j]}] ");
    }
    return Columns;
}

int[,] array = new int[4, 6];
FillArray(array);
System.Console.WriteLine("Дан исходный массив:");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Среднее арифметическое столбцов: ");
SrArifmColumns(array);