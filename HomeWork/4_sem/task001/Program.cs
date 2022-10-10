// Home Work. 4 sem. 1 example.
// Напишите программу, которая принимает на вход два числа
// (А и В) и возводит число А в целую степень В. (!!Без MathPow!!)
// 2 3

int InputNumber(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int VvodStepen(string text, int number, int stepen, int result)
{

    for (int index = 0; index < stepen; index++)result = result * number;
    Console.WriteLine(text + result);
    return number;
}
int result = 1;
int number = InputNumber("Введите число A ");
int stepen = InputNumber("Введите число B ");
VvodStepen($" Число A ({number}) в степени B ({stepen}) = ", number, stepen, result);