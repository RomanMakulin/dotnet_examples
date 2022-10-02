// Найти максимум из троек чисел
// и дальше найти одно максимальное из всех

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

int a1 = 23, a2 = 21, a3 = 32;
int b1 = 25, b2 = 11, b3 = 66;
int c1 = 12, c2 = 61, c3 = 52;

int max1 = Max(a1, a2, a3);
int max2 = Max(b1, b2, b3);
int max3 = Max(c1, c2, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);
