// Задача 1. Напишите метод, который принимает на вход трехзначное
// число и на выходе показывает вторую цифру этого числа.

// 1. Метод ввода трехзначного числа
// 2. Расчетная часть (показать вторую цифру числа)

int Input(string text) // Ввод числа
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    
    return number;
}

int Method(int number) // Расчетная часть
{
    if (100 <= number && number <= 999)
    {
    int value = number / 10;
    int result = value % 10;

    Console.WriteLine($"Вторая цифра числа = {result}");
    }
    else
    {
        Console.WriteLine("Введено некорректное число");
    }

    return number;
}

int number = Input("Введите трехзначное число: ");
Method(number);




