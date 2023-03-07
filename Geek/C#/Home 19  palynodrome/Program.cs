// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет,является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Fivedigit(int digit)
{
    return digit < 100000 & digit > 9999;

}


void Palidrome(int num)
{

    int x1 = num % 10; //первый разряд
    int x2 = num / 10 % 10; //второй разряд
                            // int x3 = num/100 % 10; третий разряд
    int x4 = num / 1000 % 10; //четвертый разряд
    int x5 = num / 10000; //пятый разряд

    if (x1 == x5 & x2 == x4)
    {
        Console.WriteLine($"Число {num} является Палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} не является Палиндромом");

    }

}


Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());

if (Fivedigit(N) == true)
{
    Palidrome(N);
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}


//Вопрос ниже, почему не срабатывает тернарный метод, пробовал разные варианты??
//Fivedigit(N) == true ? Palidrome(N) :  Console.WriteLine("Вы ввели не пятизначное число");

