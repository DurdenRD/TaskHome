// // Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

int Third(int n)
{
    if (n < 0)
    {
        n = -n;
    }

    int a = n / 100;
    int b = a % 10;

    return b;
}
bool Noresult(int x)
{
    return x == 0;
}

Console.WriteLine("Введите цедле число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = Third(number);

Console.WriteLine(Noresult(result) ? $"{number} -> третьей цифры нет." : $"{number} -> {result}");
