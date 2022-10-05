Console.WriteLine("26. Возведите число А в натуральную степень B используя цикл");

int input(string text)// Вводим число в консоль с клавиатуры
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Method(int A, int B)
{
    int AStr = Convert.ToInt32(Math.Pow(A, B));
    Console.WriteLine($"Число {A} в степени {B} = {AStr}");
    return AStr;
}

int A = input("Введите число A = ");
int B = input("Введите число B = ");
Method(A, B);