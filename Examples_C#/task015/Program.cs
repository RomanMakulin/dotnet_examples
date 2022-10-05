Console.WriteLine("Найти кубы чисел от 1 до N");
// Ввод числа N
int Input(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
// Расчетная часть
int Math(int number)
{
    while (1 <= number)
    {
    int numberSqr = number * number;
    number--;
    Console.WriteLine($"Корень из числа {number+1} = {numberSqr}");       
    }
return number;
}
// Код
int number = Input("Введите число = ");
Math(number);
