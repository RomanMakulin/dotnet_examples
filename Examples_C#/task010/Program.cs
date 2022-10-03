// Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 1. Прописать заданное число int a
// 2. Задать число (ввод с клавиатуры)
// 3. Расчетная часть 
// 4. Вывод

// Прописать заданное число int a


// Задать число (ввод с клавиатуры)
double Method(string text)
{
    Console.Write(text);
    double number = double.Parse(Console.ReadLine());
    return number;
}

// Расчетная часть 
double Method2(double result, double a)
{
    double value = result % a;
    if (value != 0 )
    {
        Console.WriteLine($"Остаток от деления = {value}");
    }
    else
    {
         Console.WriteLine($"Введенное число {result} кратно заданному {a}");
    }
    return value;
}

// Вывод
double number = Method("Введите число = ");
double a = 12;
Method2(number, a);



