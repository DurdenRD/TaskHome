// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("ведите коэфицент к1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите коэфицент b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите коэфицент к2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите коэфицент b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (Rules(k1, b1, k2, b2))
{
    double x = Vec1(k1, b1, k2, b2);
    double y = Vec2(k1, b1, k2, b2);
    Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} точка пересечения -> ({x}, {y})");
}

// double x  = Vec1(k1, b1, k2, b2);
// double y = Vec2(k1, b1, k2, b2);


// y = k1 * x + b1, y = k2 * x + b2; 

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1 x + b1 = k2 x + b2
// x(k1-k2) = b2 - b1
// x = b2-b1/k1-k2

double Vec1(double i1, double j1, double i2, double j2)
{
    double x1 = (j2 - j1) / (i1 - i2);
    return x1;
}

double Vec2(double i1, double j1, double i2, double j2)
{
    double y1 = i1 * (j2 - j1) / (i1 - i2) + j1;
    return y1;
}

bool Rules(double i1, double j1, double i2, double j2)
{
    if (i1 == i2)
    {
        if (i1 == i2 & j1 == j2)
        {
            Console.WriteLine("прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("прямые паралельны");
            return false;
        }
    }

    return true;

}

