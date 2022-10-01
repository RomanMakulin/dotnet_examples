// Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int  A = 4, B = -3, C = 7;
string resultA = "Число четное";
string resultB = "Число четное";
string resultC = "Число четное";

if (A % 2 != 0)
{
    resultA = "Число не четное";
}

if (B % 2 != 0)
{
    resultB = "Число не четное";
}

if (C % 2 != 0)
{
    resultC = "Число не четное";
}

Console.WriteLine("Даны числа: 4, -3, 7");
Console.WriteLine($"Из них: 4 - {resultA}, -3 - {resultB}, 7 - {resultC}");