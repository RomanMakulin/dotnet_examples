Console.WriteLine("Подсчитать сумму цифр в числе");

int Input(string text)

{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum(int number)
{
    int index = 0;
    int result = 0;
    while (index <= number)
    {
        result += index;
        index++;
    }
Console.Write($"Сумма элементов числа {number} = {result} ");
    return number;
}

int number = Input("Введите число = ");
Sum(number);