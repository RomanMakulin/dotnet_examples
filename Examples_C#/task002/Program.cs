// Даны два числа. Показать большее и меньшее число

int A = 10;
int B = 10;
int max = 0;
int min = 0;

if (A==B)
{
 Console.Write("У вас числа равны");

}

else if (A>B)
{
    max = A;
    min = B;
    
Console.Write("Макисмальное значение = ");
Console.WriteLine(max);

Console.Write("Минимальное значение = ");
Console.WriteLine(min);
}

else if (A<B)
{
    max = B;
    min = A;
    
Console.Write("Макисмальное значение = ");
Console.WriteLine(max);

Console.Write("Минимальное значение = ");
Console.WriteLine(min);
}