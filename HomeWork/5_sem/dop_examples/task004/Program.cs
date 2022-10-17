// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = Convert.ToInt32(new Random().Next(-100, 200));
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) System.Console.Write($"{collection[i]}  ");
}
int Count(int[] collection, int sum)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] >= 0 && collection[i] <= 99)
        {
            sum = sum + 1;
        }
    }
    System.Console.Write(sum);
    return sum;
}

int sum = 0;
int[] array = new int[123];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Count(array, sum);