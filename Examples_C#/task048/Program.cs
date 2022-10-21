// 58. Написать программу, которая в двумерном массиве 
// заменяет строки на столбцы или сообщить, что это невозможно 
// (в случае, если матрица не квадратная).

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 10);
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
void ChangeArr(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write($"{array[j, i]} \t");
            }
            System.Console.WriteLine();
        }
    }
    else System.Console.WriteLine("Матрица не квадратная ");
}

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Проведена замена строк на столбцы: ");
ChangeArr(array);