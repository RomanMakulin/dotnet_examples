// 53. В двумерном массиве показать позиции числа, 
// заданного пользователем или указать, что такого элемента нет.

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
int Search(int[,] array, int find)
{
    find = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Координаты выбранного числа: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == find)
            {
                System.Console.Write($"[{i}, {j}]  ");
            }
        }
    }
    return find;
}

int find = -1;
int[,] array = new int[5, 6];
FillArray(array);
System.Console.WriteLine("Массив: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Введите искомое число: ");
Search(array, find);
