// 21. Программа проверяет пятизначное число на палиндромом.
// Пример с использованием конвертирования в string

// Ввод пятизначного числа и приравнивание его в строку
int Input(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// Расчетная часть (проверка на палиндром), 
// используя перевод числа в строку

int String(int number)
{
    if (number > 99999)
    {
        Console.WriteLine("Введено некорректное значение. Повторите попытку ввода пятизначного числа.");
    }

    else
    {
        string numberText = number.ToString();

        if (numberText[0] == numberText[4] && numberText[1] == numberText[3])
        {
            Console.WriteLine("Число является палиномом");
        }
        else
        {
            Console.WriteLine("Число не является палиномом");
        }
    }
    return number;
}

int number = Input("Введите число = ");
String(number);