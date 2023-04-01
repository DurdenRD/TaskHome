//Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Ведите натуральное число M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите натуральное число N = ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < 0 || N < 0) Console.WriteLine("Ввели не натуральное число(а)");
else Console.Write($"M = {M}; N = {N} -> {NaturNumber(M, N)} ");



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
