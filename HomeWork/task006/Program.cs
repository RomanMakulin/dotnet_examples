/*/
Задача 2. (Второй семинар)
Напишите метод, который выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
/*/

// Вводим число с клавиатуры
int Input(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Расчетная часть

int Digit(int number)
{
    int value = number / 10^number * 10^3;
    int result1 = value / 10;
    int result2 = result1 % 10;

    Console.WriteLine($"Третья цифра числа = {result2}");
    return result2;
}

int number = Input("Введите число = ");
Digit(number);