System.Console.WriteLine("60. Составить частотный словарь элементов двумерного массива");
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(1, 7);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($"{array[i, j]}  ");
        System.Console.WriteLine();
    }
}
int[] ToOneMassiv(int[,] array)
{
    int[] newArr = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
        }
    }
    return newArr;
}


System.Console.Write("Введите размер массива (количество рядов): ");
int sizeA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите размер массива (количество столбцов): ");
int sizeB = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[sizeA, sizeB];
int[] newArr = new int[array.GetLength(0) * array.GetLength(1)];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ToOneMassiv(array);

