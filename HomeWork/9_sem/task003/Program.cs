// Example 60. Сформируйте трехмерный массив из неповторяющихся двухзначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя
// индексы каждого элемента. Massive: 2x2x2.
// 66(0,0,0)   25(0,1,0)
// 34(1,0,0)   41(1,1,0)
// 27(0,0,1)   55(1,1,1)

int[,,] array = new int[2, 2, 2];
void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(0, 10); ;
            }
        }
    }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]} \t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
void DontRepeatArrayWithIndexElements(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                for (int m = k + 1; m < array.GetLength(2); m++)
                {
                    if (array[i, j, k] == array[i, j, m])
                    {
                        array[i, j, m] = new Random().Next(20, 30);
                    }
                }


                System.Console.Write($"{array[i, j, k]} \t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
System.Console.WriteLine("***");
DontRepeatArrayWithIndexElements(array);