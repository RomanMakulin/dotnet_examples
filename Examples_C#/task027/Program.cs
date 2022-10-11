Console.WriteLine("37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");

void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++) collection[index] = new Random().Next(1, 10);
}
void PrintArray(int[]collection)
{
    for (int index = 0; index < collection.Length; index++) Console.Write(" " + collection[index]);
}

int numbers(int[] collection, int result)
{
   int[] NewArray = new int{collection[index]}
    
}
int result = 0;
int[] array = new int [8];
FillArray(array);
PrintArray(array);
numbers(array, result);