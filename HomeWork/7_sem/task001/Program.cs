// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
int SearchArrayElement(int[,] array, int find)
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if (a >= array.GetLength(0) || b >= array.GetLength(1))
    {
        System.Console.WriteLine("Вы вышли за пределы матрицы. Вывод числа невозможен");
    }
    else for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[a, b] == array[i, j]) find = array[i, j];
            }
        }
    return find;
}

int find = 0;
int[,] array = new int[4, 6];
FillArray(array);
PrintArray(array);
System.Console.Write("Введите номер столбца и строки (начиная с нулевого значения): ");
System.Console.WriteLine();
System.Console.WriteLine($"Число по заданным координатам = {SearchArrayElement(array, find)} ");