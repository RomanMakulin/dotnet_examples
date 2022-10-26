// 1. Есть число N. Скольно групп M, можно получить при разбиении всех чисел на 
// группы, так чтобы в одной группе все числа были взаимно просты.
// Например для N = 50, M получается 6

// Дан массив из 10 элементов. N = 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
// Разбиваем по группам числа так, чтобы если одно число делится на другое, то идет в другую группу
// группп 1: 1 ( всегда тут)
// группа 2: 2, 3, 5, 7
// группа 3: 4, 6, 9, 10
// группа 4: 8
// Суть: Если остаток - 0 - значит делится, если 1 - не делится.

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) System.Console.Write($"{array[i]} \t");
    System.Console.WriteLine();
}

int[,] Matrix(int[] numbers)
{
    int c = 1;
    int[,] array = new int[4, 4];
    for (int a = 0; a < numbers.Length; a++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (numbers[a] == 1)
                {
                    array[i, j] = numbers[a];

                }
                else if (numbers[a] % 2 == 0)
                {
                    array[i, j] = numbers[a];

                }
                else if (numbers[a] % 2 == 1)
                {
                    array[i, j] = numbers[a];

                }
                System.Console.Write($"{array[i, j]} \t");
            }
            System.Console.WriteLine();
        }
    }
    return array;
}

PrintArray(numbers);
System.Console.WriteLine();
Matrix(numbers);

