//Home Work. 4 sem. 3 example.
//Напишите метод, который задает массив из 8 элементов
//и выводит их на экран


/*
Первый способ. Задаем рандомный массив.
void FillArray(int[] collection)
{
   for (int index = 0; index < collection.Length; index++) collection[index] = new Random().Next(1, 4);
}
void PrintArray(int[] collection)
{
   Console.Write("Массив: ");
   for (int index = 0; index < collection.Length; index++) Console.Write(" " + collection[index]);
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
/*/

/*
Второй способ. Ввод в самом коде.
int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
PrintArray(array);
/*/

// Третий способ. Вбиваем массив с консоли и выводим на экран.
void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        Console.Write($"Введите эелемент массива под индексом {index} = ");
        collection[index] = int.Parse(Console.ReadLine());
    }
}
void PrintArray(int[] collection)
{
    Console.Write("Массив: ");
    for (int index = 0; index < collection.Length; index++) Console.Write(" " + collection[index]);
}

Console.Write("Введите количество элементов массива: ");
int elements = int.Parse(Console.ReadLine());
int[] array = new int[elements];
FillArray(array);
PrintArray(array);





