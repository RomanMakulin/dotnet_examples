// Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример: [345, 897, 568, 234] -> 2

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = Convert.ToInt32(new Random().Next(1, 1000));
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) Console.Write($"{collection[i]} \t");
}
int SumChet(int[] collection, string text, int result)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0) result = result + 1;
    }
    System.Console.WriteLine(text + result);
    return result;
}

int result = 0;
Console.Write("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
SumChet(array, $"Количество четных эллементов массива: ", result);