// 21. Программа проверяет пятизначное число на палиндромом.
// Пример: 11311

// Ввод пятизначного числа
int Input(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Расчетная часть
int Math(int number)
{
    int number5 = number % 10;
    int number4 = (number / 10) % 10;
    int number3 = (number / 100) % 10;
    int number2 = (number / 1000) % 10;
    int number1 = (number / 10000) % 10;

       if (number5 == number1 && number4 == number2)
       { 
        Console.WriteLine("Данное число = палиндром");
       }

       else 
       {
        Console.WriteLine("Данное число = не палиндром");
       }

    return number;
}

int number = Input("Введите пятизначное число = ");
Math(number);