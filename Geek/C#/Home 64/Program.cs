// Задача 64: Задайте значение N.
//  Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Ведите натуральное отличное от 0 число N = ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
    Console.WriteLine("Ввели число не соответсвующее условию");
else
{
    Console.Write($"N = {N} -> ");
    NaturNumber(N);
}

void NaturNumber(int n)
{
    if (n == 0)
        return;
    NaturNumber(n - 1);
    Console.Write($"{n} ");
}
