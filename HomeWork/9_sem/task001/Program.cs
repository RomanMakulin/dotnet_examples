// Example 66. 
// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов 
// в промежутке от M до N.
// m = 1; n = 15. ElementsSum = 120.

int m = 1, n = 15;
int ElementsSum(int n, int m)
{
    if (n == m) return m;
    return n + ElementsSum(n - 1, m);
}
System.Console.WriteLine($"Elements sum = {ElementsSum(n, m)}");