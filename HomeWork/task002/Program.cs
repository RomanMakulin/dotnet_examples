// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 2, b = 3, c = 7;
int d = 44, e = 5, f = 78;
int x = 22, y = 3, z = 9;
int max1 = 0, max2 = 0, max3 = 0;
// Первая тройка чисел
if (a > b)
{
    max1 = a;
}
else 
{
    max1 = b;
}

if (max1 < c)
{
    max1 = c;
}
Console.WriteLine($"Даны три числа: {a},{b},{c}");
Console.WriteLine($"Максимальное значение = {max1}");
// Вторая тройка чисел
if (d > e)
{
    max1 = d;
}
else 
{
    max1 = e;
}

if (max1 < f)
{
    max1 = f;
}
Console.WriteLine($"Даны три числа: {d},{e},{f}");
Console.WriteLine($"Максимальное значение = {max1}");
// Третья тройка чисел
if (x > y)
{
    max1 = x;
}
else 
{
    max1 = y;
}

if (max1 < z)
{
    max1 = z;
}
Console.WriteLine($"Даны три числа: {x},{y},{z}");
Console.WriteLine($"Максимальное значение = {max1}");