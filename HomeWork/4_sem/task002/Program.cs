// Home Work. 4 sem. 2 example.
// Напишите метод, который принимает на вход число и выдает сумму цифр в числе

int input(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int sum(string text, int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    Console.Write(text + result);
    return result;
}
int number = input("Введите число = ");
sum("Сумма элементов числа = ", number);