// Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// Пример:
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        System.Console.Write($"Введите число под индексом {i} = ");
        collection[i] = int.Parse(Console.ReadLine());
    }
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) System.Console.Write($"{collection[i]} \t");
}
int FindNumber(int[] collection, int find)
{
    int result = -1;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] == find) result = collection[i];
    }
    Console.WriteLine(result);
    return find;
}

System.Console.Write("Введите искомое число: ");
int find = int.Parse(Console.ReadLine());
int[] array = new int[6];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Искомое число присутствует:  "); // Выдаст -1 если числа там нет
FindNumber(array, find);
