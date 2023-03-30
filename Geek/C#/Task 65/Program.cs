//Вывести значения от M до N.


Console.Write("Ведите M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите N = ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {M}; N = {N} ->  ");

NaturNumber(M, N);

void NaturNumber(int m, int n)
{
    if (m < n)
    {
        NaturNumber(m, n - 1);
        Console.Write($"{n} ");
    }
    else if (m > n)
    {
       Console.Write($"{m} ");
        NaturNumber(m - 1, n);
        
    }
    else 
    {
        Console.Write($"{m} ");

    }
}
