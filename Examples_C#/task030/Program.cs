// Есть магазин "Ромашка"
// Охранник ведёт журнал посещения
// 11-13
// 10-14
// 9-10
// 11-22
// 18-18
// 0-23
// 4-5
// 4-5
// 4-5

// Суть: показать интервалы, когда было больше всего 
// людей в магазине
// string s = "11-44";
// var pos = s.IndexOf('-');
// System.Console.WriteLine(s.Substring(0, pos));
// System.Console.WriteLine(s.Substring(pos + 1));

// string[] arg = s.Split('-');
// System.Console.WriteLine(arg[0]);
// System.Console.WriteLine(arg[1]);
// 1 2 3 4 5 6 


void FillArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    while (index < count)
    {
        collection[index] += 1;

        index++;
    }
}
void PrintArray(int[] collection)
{
    int index = 0;
    int count = collection.Length;
    Console.Write("Массив: ");
    while (index < count)
    {
        Console.Write("  " + collection[index]);
        index++;
    }
}


int[] array = new int[6];
FillArray(array);
PrintArray(array);
