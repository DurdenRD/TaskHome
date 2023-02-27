// Напишите программу, которая на вход принимает два числа. 
// Проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да
//  a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число:");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int a2 = Convert.ToInt32(Console.ReadLine());
int x = a1/a2;


if (a2 == x)
{
    Console.WriteLine($"число {a1} является квадтратом {a2} ");
}
else
{
     Console.WriteLine($"число {a1} не является квадтратом {a2} ");

}