// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
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
void ResultMatrixC(int[,] A, int[,] B)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    int[,] C = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++) C[i, j] += A[i, k] * B[k, j];
            System.Console.Write($"{C[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
FillArray(array1);
FillArray(array2);
System.Console.WriteLine("Матрица A:");
PrintArray(array1);
System.Console.WriteLine("Матрица B:");
PrintArray(array2);
System.Console.WriteLine();
System.Console.WriteLine("Результирующая матрица A x B = C ");
ResultMatrixC(array1, array2);
