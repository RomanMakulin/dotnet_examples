// 55. Дан целочисленный массив. Найти среднее 
// арифметическое каждого из столбцов.

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"{collection[i, j]} \t");
        }
        Console.WriteLine();
    }
}
double[] SrArifm(int[,] collection)
{
    double result = 0;
    double[] OneArr = new double[collection.GetLength(1)];
    for (int j = 0; j < collection.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < collection.GetLength(0); i++)
        {
            sum += collection[i, j];
        }
        OneArr[j] = sum / collection.GetLength(0);
        System.Console.Write($"{OneArr[j]} \t");
    }
    return OneArr;
}

double OneArr = 0;
int[,] array = new int[4, 6];
FillArray(array);
PrintArray(array);
Console.WriteLine("___________________________________________");
SrArifm(array);
