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
}
int Repeat(int[] collection, int number)
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] == collection[i])
        {
            number = collection[i];
        }
        if (number == number)
    }
}