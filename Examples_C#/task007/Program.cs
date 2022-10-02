// Написать программу вычисления значения функции y = f(a)
// y = f(a) = sin(a + cos(1/a))

// double y = 0;
// double a = 0;

// Считаем функцию
double GetFunction(double a)
{
    double Part1 = Math.Cos(1/a);
    double result = Math.Sin(a + Part1);
    return result;
}
// Запрашиваем у пользователя значения аргумента и пишем
double GetValue(string text)
{
    Console.Write(text + " : ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

double arg = GetValue("Введите аргумент функции: ");
double function = GetFunction(arg);
Console.WriteLine ($"Значение функции: {function} ");