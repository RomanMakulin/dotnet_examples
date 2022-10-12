Console.WriteLine("60. Составить частотный словарь элементов двумерного массива");

/* Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Пример: 
Есть набор данных 
{ 1, 9, 9, 0, 2, 8, 0, 9 }
частотный массив может быть представлен так:
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза    /*/
void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(1, 5);
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++) Console.Write(" " + collection[i]);
}//                                          0 1 2 3 4 5
int Repeat(int[] collection, string text, int number) //  2 1 2 5 1 5
{
    int result = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        for (int j = 0; j < collection.Length; j++)
        {
            if (collection[i] == collection[j])
            {
                result = collection[i] + collection[j];
            }
            Console.WriteLine(text, collection[i], result);
        }

    }
    return result;
}


int result = 0;
int[] array = new int[5];
FillArray(array);
PrintArray(array);
Repeat(array, $"Число , повторяется {result} раз", result);
