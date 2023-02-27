//  Напишите программу, 
//  которая на вход принимает два числа и выдаёт, 
//  какое число большее, а какое меньшее.

Console.Write("Введите первое целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{

    Console.WriteLine("Числа равные, попробуйте еще раз!");

}
else
{
    if (a > b)
    {
        Console.WriteLine($"Число a={a} - большее число, а Число b={b} - меньшее число.");
    }
    else
    {
        Console.WriteLine($"Число b={b} - большее число, а Число a={a} - меньшее число.");

    }
}


