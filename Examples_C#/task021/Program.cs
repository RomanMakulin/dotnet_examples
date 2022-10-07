Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру");
// Задаем массив рандомных чисел. Показываем в нем четные кубы чисел.
void FillArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    while (index < count)
    {
        collection[index] = new Random().Next(0,6);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    Console.Write("Массив чисел = ");
    while (index < count)
    {
        Console.Write("  " + collection[index]);
        index ++;
    }
}

int Math1(int[] collection, int number)
{
    int index = 0;
    int count = collection.Length;
    while (index < count)
    {
        number = Convert.ToInt32(Math.Pow(collection[index], 3));
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} - четное число (куб от {collection[index]})");
        }
        index++;
    }
    return number;
}

int number = 1;
int[] array = new int[6];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int number1 = Math1(array, number);