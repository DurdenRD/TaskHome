// Задача 4: Напишите программу, 
// которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.


Console.Write("Введите первое целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число с: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b>max)
{
    max=b;
}

    if (c>max)
    {
        max=c;
    }
    
            Console.WriteLine($"Максимальное число равно: {max}");
