// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = Convert.ToInt32(new Random().Next(0, 4));
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) System.Console.Write($"{collection[i]}  ");
}
int Proisv(int[] collection, int result)
{
    int NewLength = collection.Length - 1;
    for (int i = 0; i < collection.Length; i++)
    {
        if (i < NewLength)
        {
            result = collection[i] * collection[NewLength];
            System.Console.WriteLine($"{collection[i]}x{collection[NewLength]} = {result}");
            NewLength = NewLength - 1;
        }
    }
    return result;
}

int[] array = new int[8];
int result = 1;
FillArray(array);
System.Console.WriteLine("Массив:");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Произвдеение пар чисел массива: ");
Proisv(array, result);