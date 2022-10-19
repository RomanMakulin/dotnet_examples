/*

51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

54. В матрице чисел найти сумму элементов главной диагонали

/*/

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
//52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] Change(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = (int)Math.Pow(array[i, j], 2);
        }
    }
    return array;
}

int[,] array = FillArray(5, 8);
PrintArray(array);
array = Change(array);
System.Console.WriteLine();
PrintArray(array);