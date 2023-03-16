//Число в двоичный код записи


int BinareCode(int num)

{
    int count = 0;
    for (int i = 1; num != 0; i++)
    {
        num = num / 2;
        count = i;

    }
    return count;
}

int[] Array(int len, int num)
{
    int[] arr = new int[len];

    for (int i = 0; i != len; i++)
    {

        arr[len-1-i] = num % 2;
        num = num / 2;
    }
    return arr;
}


// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}");
//     }

// }

Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

int size = BinareCode(N);
Console.WriteLine(size);
int[] array = Array(size, N);

// PrintArray(array);


string result = string.Concat(array);
int BinN = Convert.ToInt32(result);

Console.WriteLine($"Число N в двоичной системе -> {BinN}");





