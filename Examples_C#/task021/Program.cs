Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру");
void FillArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    while (index < count)
    {
        collection[index] = new Random().Next(0,4);
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
        Console.WriteLine("  " + collection[index]);
        index ++;
    }
}

int Math(int[] collection, int number)
{
    int index = 0;
    int count = collection.Length;
    int stephen = 3;
    int A = collection[index];

    while (index < count)
    {
        number = Convert.ToInt32(Math.Pow(A, stephen));
        if (number % 2 == 0)
        {
            
            Console.WriteLine($"{number} - четное число");
        }
        index++;
    }
    return number;
}

int number = 1;
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int number1 = Math(array, number);