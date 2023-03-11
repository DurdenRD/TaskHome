//от 1 до N - произведения


int Product(int x)

{
    int n = 2;
    int productNumber = 1;

    checked
    {
        do
        {
            productNumber *= n;
            n++;

        }
        while (n <= x);
    }
    return productNumber;

}


Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());


int result = Product(N);
Console.WriteLine($"Произведение чисел от 1 до {N} = {result}");