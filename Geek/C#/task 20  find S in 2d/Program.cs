//На вход две кординаты и растояние между ними 2d

Console.WriteLine("Введите значение x1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение x2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

int Xcord(int a1, int a2)
{
    int a = (a2 - a1);
    return a = a*a;
}

int Ycord(int b1, int b2)
{
    int b = b2 - b1;
    return b = b*b;
}

double result = Math.Sqrt (Xcord(x1,x2) + Ycord(y1,y2));

Console.WriteLine($"растояние от одной точки до другой: {result}");
