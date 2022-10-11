Console.WriteLine("37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");

void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++) collection[index] = new Random().Next(10, 100);
}
void PrintArray(int[]collection)
{
    for (int index = 0; index < collection.Length; index++) Console.Write(" " + collection[index]);
}

int[] array = new int [123];
FillArray(array);
PrintArray(array);