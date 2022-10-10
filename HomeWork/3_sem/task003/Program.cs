// Home Work. 3 sem. 3 example.
// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.

int input(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Maths(string text, int number)
{
    for (int index = 1; index < number; number--)
    {
        int result = Convert.ToInt32(Math.Pow(number, 3));

        Console.Write(number);
        Console.WriteLine(text + result);
    }
    return number;
}

int number = input("Введите число: ");
Console.WriteLine("Таблица кубов от 1 до N");
Maths(" в кубе = ", number);