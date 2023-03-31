//Вывести сумму значения от M до N.


Console.Write("Ведите M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите N = ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {M}; N = {N} -> {NaturNumber(M, N)} ");


int  NaturNumber(int m, int n)
{
     if (m < n)
    {
      return  n + NaturNumber(m, n - 1);
    }
    else if (m > n)
    {
       return  m + NaturNumber(m - 1, n);
        
    }
    else 
    {
        return n;
    }
}
