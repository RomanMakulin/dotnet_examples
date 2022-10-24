// 1. Есть число N. Скольно групп M, можно получить при разбиении всех чисел на 
// группы, так чтобы в одной группе все числа были взаимно просты.
// Например для N = 50, M получается 6

// Одно из решений :

// Группа 1: 1 
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
// Группа 5: 7 16 24 36 40 
// Группа 6: 5 32 48

// Ещё одно решение:
// Группа 1: 1 
// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
// Группа 5: 16 24 36 40 
// Группа 6: 32 48

int[] Numbers = new int[50];
for (int i = 0; i < Numbers.Length; i++)
{
   if(Numbers[i] == 
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 99);
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

int Matrix(int[] N, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

        }
    }
}