Console.WriteLine("37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");
void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++) collection[index] = new Random().Next(1, 10);
}
void PrintArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++) Console.Write(" " + collection[index]);
}
int numbers(int[] collection, int result)
{
    int number = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] < 8)
        {
            number = number + 1;
            result = number;
        }
    }
    Console.Write(result);
    return result;
}
int result = 0;
int[] array = new int[8];
FillArray(array);
PrintArray(array);
numbers(array, result);