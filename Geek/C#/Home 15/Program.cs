// Задача 15: Напишите программу,
//  которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, 
//  является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Int a = Console.WriteLine("Понедельнмк");
// Int b = Console.WriteLine("Вторник");
// Int c = Console.WriteLine("Среда");
// Int d = Console.WriteLine("Четверг");
// Int e = Console.WriteLine("Пятница");
// Int f = Console.WriteLine("Суббота ");
// Int g = Console.WriteLine("Воскресенье");

bool Weekend(int x)
{

    return x == 7 || x == 6;
}

Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 & day < 8)
{
   Console.WriteLine(Weekend(day) ? $"{day} -> да" : $"{day} -> нет ");

}
else
{
    Console.WriteLine("Не верное число");
}