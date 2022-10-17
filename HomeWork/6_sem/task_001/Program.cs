// Урок 6. Двумерные массивы и рекурсия
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        System.Console.Write($"Введите число под индексом {i} = ");
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) System.Console.Write($"{collection[i]} \t");
}
int Count(int[] collection, int result)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 0)
        {
            result = result + 1;
        }
    }
    System.Console.Write(result);
    return result;
}

int result = 0;
System.Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Количество элементов больше нуля: ");
Count(array, result);