// Даны две матрицы A и B. 
// Вывести итоговую C, перемножив A, B
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(0, 10);
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

int NextArray(int[,] array, int[,] array2)
{
    int[] sum = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = array[]
        }
    }
}

/*/
c11 = a11 · b11 + a12 · b21 + a13 · b31 = 2 · 2 + 3 · 4 + 5 · 5 = 4 + 12 + 25 = 41

c12 = a11 · b12 + a12 · b22 + a13 · b32 = 2 · 6 + 3 · 3 + 5 · 7 = 12 + 9 + 35 = 56

c13 = a11 · b13 + a12 · b23 + a13 · b33 = 2 · 2 + 3 · 1 + 5 · 8 = 4 + 3 + 40 = 47

c21 = a21 · b11 + a22 · b21 + a23 · b31 = 1 · 2 + 4 · 4 + 2 · 5 = 2 + 16 + 10 = 28

c22 = a21 · b12 + a22 · b22 + a23 · b32 = 1 · 6 + 4 · 3 + 2 · 7 = 6 + 12 + 14 = 32

c23 = a21 · b13 + a22 · b23 + a23 · b33 = 1 · 2 + 4 · 1 + 2 · 8 = 2 + 4 + 16 = 22

c31 = a31 · b11 + a32 · b21 + a33 · b31 = 7 · 2 + 8 · 4 + 1 · 5 = 14 + 32 + 5 = 51

c32 = a31 · b12 + a32 · b22 + a33 · b32 = 7 · 6 + 8 · 3 + 1 · 7 = 42 + 24 + 7 = 73

c33 = a31 · b13 + a32 · b23 + a33 · b33 = 7 · 2 + 8 · 1 + 1 · 8 = 14 + 8 + 8 = 30

*/




int [,] array = new int [3, 3];
int [,] array2 = new int [3, 3];
FillArray(array);
FillArray(array2);
PrintArray(array);
System.Console.WriteLine();
PrintArray(array2);