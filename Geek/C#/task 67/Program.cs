// на вход число, возрват сумму цифр.

Console.Write("Ведите N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("сумма цифр N = ");
//int result = 0;
 SumDig(N);
Console.Write(N);

void SumDig(int num)
{
       int sum = 0;

    if (num == 0)
        

    SumDig( num / 10);
    sum+= num % 10;
    return sum;
    
    
}
