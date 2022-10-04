/*/
Напишите метод, который принимает на вход цифру, обозначающую
день недели и проверяет, является ли этот день выходным.
/*/

// Ввод числа с клавиатуры 
int Input(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());

    return number;
}

// Расчетная часть (является ли выходным (6,7?))
int DayOff(int number)
{
    if (number < 1)
    {
        Console.WriteLine("Введите число от 1 до 7");
    }
    if (number > 7)
    {
        Console.WriteLine("Введите число от 1 до 7");
    }
    
    if (1 <= number && number <=7 )
    {
        if (1 <= number && number <= 5)
        {
            Console.WriteLine("Это рабочий день");
        }

        else
        {
            Console.WriteLine("Это выходной день");
        }
    }

    return number;
}


int number = Input("Введите цифру дня недели = ");
DayOff(number);
