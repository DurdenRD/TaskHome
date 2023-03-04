// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.


int Sec(int n) 
{
    int c = n / 10; // вторая + третья
    int b = c % 10; //вторая цифра
   
    return b;
    
}

bool True(int num)
{
    return num > 99 && num <1000 || num < -99 && num > -1000;
}


Console.WriteLine("Введите трех значное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = Sec(number);

if (result<0)
 {
    result = -result;
}
Console.WriteLine(True (number) ?  $"{number}->{result}" : "Это не трехзначное число, досвидания умник!"); 

