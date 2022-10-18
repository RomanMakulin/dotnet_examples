// 56. Написать программу, которая обменивает элементы первой строки и последней строки
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
void SumEl(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        var temp = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = array[0, i];
        array[0, i] = temp;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }

}

int[,] array = new int[5, 7];
FillArray(array);
System.Console.WriteLine("Массив: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Поменял первую и последнюю строчку");
SumEl(array);