// Показать вторую цифру трёхзначного числа

int number = 234;
int secondNumber = 0;

secondNumber = ((number % 100) - (number % 10)) / 10;
Console.Write($"Вторая цифра от 3-ех значного числа = {secondNumber} ");

