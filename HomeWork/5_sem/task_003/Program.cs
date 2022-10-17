// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Пример:
// [3 7 22 2 78] -> 76

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = Convert.ToInt32(new Random().Next(10, 200));
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) System.Console.Write($"{collection[i]} \t");
}
int Difference(int[] collection, int result)
{
    int max = collection[0];
    int min = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] >= max) max = collection[i];
        if (collection[i] <= min) min = collection[i];
    }
    System.Console.WriteLine(result = max - min);
    return result;
}

int result = 0;
System.Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Разница между макс и мин значениями массива: ");
Difference(array, result);