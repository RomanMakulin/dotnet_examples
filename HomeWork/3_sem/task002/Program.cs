// Home Work. 3 sem. 2 example.
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// Пример: A(3, 6 , 8); B (2, 1, -7) -->> 15.84

double Number(string text)
{
    Console.Write(text + ": ");
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void PrintNumber(double ax, double ay, double az,
                 double bx, double by, double bz,
                 double result)
{
    string output = "|A(" + ax + ", " + ay + ", " + az + "); B(" + bx + ", " + by + ", " + bz + ")| = " + result;
    Console.WriteLine(output);
}
double Dist(double ax, double ay, double az,
            double bx, double by, double bz)
{
    double x = (ax - bx) * (ax - bx);
    double y = (ay - by) * (ay - by);
    double z = (az - bz) * (az - bz);
    double result = Math.Sqrt(x + y + z);
    return result;
}

double ax = Number("ax"); double ay = Number("ay"); double az = Number("az");
double bx = Number("bx"); double by = Number("by"); double bz = Number("bz");

double distance = Dist(ax, ay, az, bx, by, bz);
PrintNumber(ax, ay, az, bx, by, bz, distance);