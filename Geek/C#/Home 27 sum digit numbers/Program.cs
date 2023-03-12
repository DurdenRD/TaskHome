// Задача 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = SumDigit(N);
Console.WriteLine($"сумма цифр числа {N} = {result}");





int SumDigit(int num)
{

    int sumdig = 0;

    if (num < 0)
    {
        num = -num;
    }


    do
    {

        sumdig += num % 10;
        num = num / 10;

    }
    while (num != 0);

    return sumdig;
}

// int NegativeSum(int num)
// {
//     if (num < 0)
//     {
//         num = -num;
//     }
// }
