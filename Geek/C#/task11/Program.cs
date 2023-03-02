
int FirstThird(int n) 
{
    int c = n % 10; //первая цифра цифра
    int a = n/100; //третья цифра
    int x = c+10*a;
    return x;
    
}

//int number = new Random().Next(100, 1000);
int number = 100;
Console.WriteLine(number);

int result = FirstThird(number);
Console.WriteLine(result);



