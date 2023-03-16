//На вход три числа, могут ли быть трегольником? 
//(одни сторона меньше суммы двух других)

Console.Write("Введите число a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число c = ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triangle(a,b,c) ? "могут быть треугольникм" : "не могут быть треугольником");


bool Triangle(int x,int y,int i)
{
    return x < y + i & y < x + i & i < x + y;
}



