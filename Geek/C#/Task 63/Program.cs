//Задать N. Вывести от 1 до N.

Console.Write("Ведите N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {N} -> ");
NaturNumber(N);


void NaturNumber(int n)
{
    if (n == 0)
        return;
    NaturNumber(n-1);
    Console.Write($"{n} ");

    
}

