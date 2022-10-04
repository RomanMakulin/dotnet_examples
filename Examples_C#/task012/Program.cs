// 17. По двум заданным числам проверять является ли одно квадратом другого

// Задаем 2 числа 
int input(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// Проверяем a = b^2?
int Math(int a, int b)
{
// проверяем первое число
    if (a == b*b)
    {
        Console.WriteLine($"Число {a} является квадратом {b}");
    }
    else
    {
        Console.WriteLine($"Число {a} не является квадратом {b}");
    }
// проверяем второе число
        if (b == a*a)
    {
        Console.WriteLine($"Число {b} является квадратом {a}");
    }
    else
    {
        Console.WriteLine($"Число {b} не является квадратом {a}");
    }
    return a;
}
int a = input("Введите число A = ");
int b = input("Введите число B = ");
Math(a, b);