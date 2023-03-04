// 16. Напишите программу, которая принимает 
// на вход два числа и проверяет, 
// является ли одно число квадратом другого.
  
// 5, 25 -> да 
// -4, 16 -> да 
// 25, 5 -> да 
// 8,9 -> нет







bool Sqr(int numb1, int numb2)
{
    return numb1 == numb2 * numb2 || numb2 == numb1 * numb1 ; 
}

Console.WriteLine("input first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Sqr(a,b) ? "да" : "нет");

//Sqr (a1,b1) ? Console.WriteLine($"{a}, {b} -> да") : Console.WriteLine($"{a}, {b} -> нет");




