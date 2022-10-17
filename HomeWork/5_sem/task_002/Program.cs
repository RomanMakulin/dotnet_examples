// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Пример:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArrey(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = Convert.ToInt32(new Random().Next(-100, 100));
}
void PrintArrey(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) System.Console.Write($"{collection[i]} \t");
}
int SumNechet(int[] collection, int result)
{
    for (int i = 1; i < collection.Length; i += 2) result = result + collection[i];
    System.Console.WriteLine(result);
    return result;
}

int result = 0;
System.Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];
FillArrey(array);
PrintArrey(array);
Console.WriteLine();
System.Console.Write("Сумма элементов, стоящих на нечетной позиции: ");
SumNechet(array, result);