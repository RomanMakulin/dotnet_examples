// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = Convert.ToInt32(new Random().Next(-100, 100));
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) System.Console.Write($"{collection[i]} \t");
}
void Switch(int[] collection)
{
    int[] NewCollection = new int[collection.Length];
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 0) System.Console.Write($"{NewCollection[i] = collection[i] * (-1)} \t");
        else System.Console.Write($"{NewCollection[i] = collection[i] * (-1)} \t");
    }
    return;
}

int[] array = new int[6];
FillArray(array);
System.Console.Write("Массив: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Смена знаков элементов массива на противположне: ");
Switch(array);