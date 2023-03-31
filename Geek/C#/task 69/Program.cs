// на вход два числа A и B, A в степень целую B.

Console.Write("Ведите A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите B = ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write($"A = {A}; B = {B} -> {Exponent(A, B)} ");


int Exponent(int x, int y)
{
    if (y ==  0) return 1;
    return x * Exponent(x, y-1);
        

    //SumDig(num / 10) % 10;
}
