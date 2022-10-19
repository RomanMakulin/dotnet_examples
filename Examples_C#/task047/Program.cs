// 57. Написать программу, упорядочивания 
// по убыванию элементы каждой строки двумерной массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

void Filter(int[,] array)
{
    int max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            max = array[i, j];
            int index = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > max)
                {
                    max = array[i, k];
                    index = k;
                }
            }
            int temp = array[i, j];
            array[i, j] = max;
            array[i, index] = temp;
            System.Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}


int[,] array = new int[4, 6];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Filter(array);