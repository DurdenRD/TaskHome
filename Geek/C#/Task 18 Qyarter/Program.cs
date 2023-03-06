//По заданому номеру четверти, показывает диапозон точек (x, y)

// int Quarter(int x, int y)
// {
//     if (x>0 && y>0) return 1;
//     if (x<0 && y>0) return 2;
//     if (x<0 && y<0) return 3;
//     if (x>0 && y<0) return 4;
//     return 0;
       
// }
string Rang (int index)
{
    if (index == 1) return "x>0, y>0";
    if (index == 2) return "x<0, y>0";
    if (index == 3) return "x<0, y<0";
    if (index == 4) return "x>0, y<0";
    return "не верная четверть!";
       
}

Console.WriteLine("Введите номер четверти:");
int quarter = Convert.ToInt32(Console.ReadLine());
string result = Rang(quarter);
Console.WriteLine (result);
