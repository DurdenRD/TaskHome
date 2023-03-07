// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


double CubeTable(int a)
{

    double x = Math.Pow(a, 3);

    return x;
}


Console.Write("Введите натурально число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 1)
{
    for (int i = 1; i <= N; i++)

    {
        Console.WriteLine($"{i}  {CubeTable(i)}");
    }
}

else
{
    Console.WriteLine("Это не натуральное число");
}



// int i = 1;
// while (i <=N )
// {
//     Console.WriteLine($"{i}  {CubeTable(i)}");
//     i++;
// }

