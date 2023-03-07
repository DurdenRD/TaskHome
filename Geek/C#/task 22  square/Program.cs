//Квадратов вывод чисел от 1 до N 
double Square(int a)
{
    double x = Math.Pow(a, 2);
    return x;
}


Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < N; i++)

// {
//     Console.Write($"{Square(i)}, ");
// }


// Console.WriteLine($"{Square(N)}.");

int i = 1;
while (i <=N )
{
    Console.WriteLine($"{i}  {Square(i)}");
    i++;
}

