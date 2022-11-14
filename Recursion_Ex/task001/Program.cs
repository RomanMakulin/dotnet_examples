// 66. Показать натуральные числа от 1 до N, N задано

Console.Write("Input N: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];


PrintArray(n);

void PrintArray(int i)
{
    if (i > 0)
    {
        System.Console.Write(i);
        PrintArray(i-1);
    }
}