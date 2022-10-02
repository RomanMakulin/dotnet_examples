// Найти расстояние 
// между 2 точками в пространстве 2D/3D
// 1. Откуда значения идут;
// 2. Вычисление
// 3. Печать результата

double GetValue(string text)
{
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

void Print(double ax, double ay, double bx, double by, double result )
{
    // |A(1,2); B(5,6)| = 5
  string output = "|A("+ax+", "+ay+"); B("+bx+", "+by+")| = "+result;
  Console.WriteLine(output);
}

double GetDistance(double ax, double ay, double bx, double by)
{
    double x = (ax - bx);
    double y = (ax - bx);
    double result = Math
}


double ax = GetValue("ax");
double ay = GetValue("ay");
double bx = GetValue("bx");
double by = GetValue("by");