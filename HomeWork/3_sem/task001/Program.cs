// Home Work. 3 sem. 1 example.
// Напишите программу, которая принимает на вход пятизначное число и проверяет 
// является ли оно палиндромом.

int Input(string text) // Задаем с консоли число
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int CheckPalindrom(int number, string text1, string text, string text2) // Расчетная часть
{
    int number5 = number % 10; int number4 = (number / 10) % 10; int number3 = (number / 100) % 10;
    int number2 = (number / 1000) % 10; int number1 = (number / 10000) % 10;
    if (number > 99999)
    {
        Console.WriteLine(text1);
    }
    else if (number5 == number1 && number4 == number2)
    {
        Console.WriteLine(text);
    }
    else
    {
        Console.WriteLine(text2);
    }
    return number;
}
int number = Input("Введите число = ");
CheckPalindrom(number, "Введено не 5-ти значное число", "Число палиндром", "Число не палиндром");
