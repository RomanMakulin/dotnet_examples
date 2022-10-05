Console.WriteLine("27. Определить количество цифр в числе");

int input(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numbers(int number)
{
    string numberText = number.ToString();
    Console.WriteLine($"Количество цифр в числе {number} = {numberText.Length}");
    return number;
}

int number = input("Введите число = ");
numbers(number);
