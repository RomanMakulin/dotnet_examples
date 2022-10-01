// Example 1. Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 5, b = 7, c = 2, d = 10, x = -9, y = -3;
int max = 0;
int min = 0;

Console.WriteLine($"Даны числа: {a}, {b}");
if (a > b)
{
    max = a;
    min = b;
}
else 
{
    max = b;
    min = a;
}
Console.WriteLine($"Максимальное число = {max}");

// Следующая пара чисел

Console.WriteLine($"Даны числа: {c}, {d}");
if (c > d)
{
    max = c;
    min = d;
}
else 
{
    max = d;
    min = c;
}
Console.WriteLine($"Максимальное число = {max}");

// Следующая пара чисел

Console.WriteLine($"Даны числа: {x}, {y}");
if (x > y)
{
    max = x;
    min = y;
}
else 
{
    max = y;
    min = x;
}
Console.WriteLine($"Максимальное число = {max}");
