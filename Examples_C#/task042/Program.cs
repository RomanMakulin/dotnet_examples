Console.WriteLine("52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");
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
void SwitchEl(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = (int)Math.Pow(array[i, j], 2);
                Console.Write($"{array[i, j]} \t");
            }
            else Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
    return;
}

int[,] array = new int[5, 6];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
SwitchEl(array);