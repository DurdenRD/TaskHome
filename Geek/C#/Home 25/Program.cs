// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
int result = Quart(a, b);
if (ValiDateExp(b))
{
    
}

    Console.WriteLine($"Число {a} в степени {b} = {result}");


int Quart(int x, int y)
{
    int quart = 1;

    for (int i = 0; i < y; i++)
    {
        quart *= x;
    }

    return quart;
}

bool ValiDateExp(int y)
{
    if (y < 0)
    {
        Console.WriteLine("Показатель не должен быть меньше 0 ");
        return false;
    }
    return true;
}


