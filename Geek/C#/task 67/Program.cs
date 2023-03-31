// на вход число, возрват сумму цифр.

Console.Write("Ведите N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("сумма цифр N = ");

//int result = 0;

Console.Write(SumDig(N));

int SumDig(int n)
{
    if (n == 0)
        return 0;
    else
        return n % 10 + SumDig(n / 10 );
        

    //SumDig(num / 10) % 10;
}
