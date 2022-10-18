Console.WriteLine("50. В двумерном массиве NxK заменить четные элементы на противоположные");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
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
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = -1 * array[i, j];
                System.Console.Write($"{array[i, j]} \t");
            }
            else Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
    return;
}

int[,] array = new int[4, 6];
FillArray(array);
System.Console.WriteLine("Массив: ");
PrintArray(array);
System.Console.WriteLine("Замена четных элементов массива на противоположные ");
SwitchEl(array);