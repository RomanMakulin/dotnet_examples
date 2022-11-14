// Example 68.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два числа неотрицательных чисел m и n.
// m = 2, n = 3 -> A(m,n) = 9;
//     3      2           = 29.

int m = 3, n = 2;
System.Console.WriteLine($"Даны значения: m = {m}, n = {n}.");
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
System.Console.WriteLine($"A(m, n) = {Akkerman(m, n)}");