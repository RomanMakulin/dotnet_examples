/*/
Задача 2. (Второй семинар)
Напишите метод, который выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
/*/

// Вводим число с клавиатуры
int Input(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Расчетная часть
int Number(int number)
{

    if (number < 100)
    {
        Console.WriteLine("Третьей цифры в числе нет.");
    }

    while (number > 100)
    {
        if (number > 999)
        {
            number = number / 10;
        }

        else
        {
            number = number % 10;
            Console.WriteLine($"Третья цифра числа = {number}");

        }
    }
    return number;
}

int number = Input("Введите число = ");
Number(number);
