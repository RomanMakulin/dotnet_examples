// 4. Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 5);
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
int[] MaxSumString(int[,] array, int sum) // Считаем сумму каждой строчки и записываем в массив
{
    int[] MaxArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        MaxArray[i] = sum;
        sum = 0;
    }
    return MaxArray;
}
int MaxStringIndex(int[] array, int result) // Вычисление максимального значения
{
    int max = 0;
    max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            result = i;
        }
    }
    System.Console.Write($"{result} ");
    return result;
}

int max = 0, sum = 0;
int[,] array = new int[7, 3];
FillArray(array); PrintArray(array);
System.Console.WriteLine();
int[] array2 = MaxSumString(array, sum);
System.Console.Write("Номер строчки с максимальной суммой элементов (начиная с 0): ");
MaxStringIndex(array2, max);