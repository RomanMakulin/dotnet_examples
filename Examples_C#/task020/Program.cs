Console.WriteLine("Написать программу вычисления произведения чисел от 1 до N");

void FillArray(int[] collection) // Заполняем массив с помощью рандомных чисел и цикла
{
    int index = 0;
    int count = collection.Length;
    while (index < count)
    {
        collection[index] = new Random().Next(1,4);
        index++;
    }
}
void PrintArray(int[] collection) // Печатаем массив путем ввода по одной цифре с циклом
{
    int index = 0;
    int count = collection.Length;
    Console.WriteLine("Массив:");
    while (index < count)
    {
        Console.Write("  " + collection[index]);
        index++;
    }
}

int Math(int[] collection, int sum)
{
    int index = 0;
    int count = collection.Length;

    while (index < count)
    {
        sum = sum * collection[index];
        index++;
    }
    Console.WriteLine($"Сумма элементов массива = {sum}");
    return sum;
}
//Код
int sum = 1;
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int sum1 = Math(array, sum);

