// 15. Дано число. Проверить кратно ли оно 7 и 23

// Задать число с клавиатуры
int Number(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Расчетная часть
int Math1(int number, int A)
{
    A = 7;
    int result = number % A;

    if (result == 0)
    {
        Console.WriteLine($"Число {A} кратно заданному");
    }
    else
    {
        Console.WriteLine($"Число {A} не кратно заданному");
    }

    return result;
}

int Math2(int number, int B)
{
    B = 23;
    int result = number % B;

    if (result == 0)
    {
        Console.WriteLine($"Число {B} кратно заданному");
    }
    else
    {
        Console.WriteLine($"Число {B} не кратно заданному");
    }

    return result;
}
int A = 7;
int B = 23;
int number = Number("Введите число = ");
Math1(number, A);
Math2(number, B);