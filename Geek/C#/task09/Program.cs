// 9. Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

 int number = new Random().Next(10,100);
 Console.WriteLine($"Случайное число из отрезка 10 - 99 = {number}");


//  int a01 = number % 10;
//  int a10 = number / 10;

//  if(a10>a01)
//  {
//     Console.WriteLine($"наибольшая цифра случайного числа = {a10}");
// }
// else
// {
//     Console.WriteLine($"наибольшая цифра случайного числа = {a01}");
    

// }

// int result = a10 > a01 ? a10 : a01;
// Console.WriteLine($"наибольшая цифра случайного числа = {result}");

int maxdigit = MaxDigit(number);
Console.WriteLine($"наибольшая цифра случайного числа = {maxdigit}");

int MaxDigit(int num)

{
    int a01 = num % 10;
    int a10 = num / 10;
    int result = a10 > a01 ? a10 : a01;
    return result;
}