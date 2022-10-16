// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = Convert.ToInt32(new Random().Next(-9, 10));
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) Console.Write("\t" + collection[i]);
}
int PlusNumber(int[] collection, int sum1, int sum2)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 0) sum1 = collection[i] + sum1;
        else sum2 = collection[i] + sum2;
    }
    Console.WriteLine($"Сумма положительных элементов массива = {sum1}");
    Console.WriteLine($"Сумма отрицательных элементов массива = {sum2}");
    return sum1;
}

int sum1 = 0;
int sum2 = 0;
int[] array = new int[6];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PlusNumber(array, sum1, sum2);