// Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Введите целое число N больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n>1)
{   
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Все четные числа от 1 до числа N = ");
    for (int i = 2; n>=i; i=i+2)
{
    Console.Write($"{i} "); 
}

}
else 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Не верное число, попробуй еще раз умник!");
}