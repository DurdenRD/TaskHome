// 12. Напишите программу, которая будет 
// принимать на вход два числа и выводить, 
// является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int Multiple(int first, int second)

{
    int multiple = first % second;

    if (multiple != 0)
    {
        Console.WriteLine($"{first},{second} -> не кратно, остаток {multiple}");

    }

    else
    {

        Console.WriteLine($"{first},{second} -> кратно");

    }

    //string a = Console.WriteLine($"{first},{second} -> не кратно, остаток {multiple}");
    //string b = Console.WriteLine($"{first},{second} -> кратно");
    // string result = multiple==0 ? a : b;
    return multiple;

}

Console.WriteLine("Введите первое число:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int y = Convert.ToInt32(Console.ReadLine());
int f = Multiple(x, y);

