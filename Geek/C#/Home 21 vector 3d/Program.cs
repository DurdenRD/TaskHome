// Задача 21
// Напишите программу, которая принимает 
// на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A.");

Console.WriteLine("Введите значение x1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение y1:");
int y1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите значение z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B.");


Console.WriteLine("Введите значение x2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

int Xcord(int a1, int a2)
{
    int a = (a2 - a1);
    return a = a * a;
}

int Ycord(int b1, int b2)
{
    int b = b2 - b1;
    return b = b * b;
}

int Zcord(int c1, int c2)
{
    int c = c2 - c1;
    return c = c * c;
}
double result = Math.Sqrt(Xcord(x1, x2) + Ycord(y1, y2) + Zcord(z1, z2));

Console.WriteLine($"растояние от точки A ({x1},{y1},{z1}) до точки B ({x2},{y2},{z2}) : {result}");
