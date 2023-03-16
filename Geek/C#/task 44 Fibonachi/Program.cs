//вывести фибоначи числа.

Console.WriteLine("введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());
// int[] array = RowNumber(N);
int[] array = new int[N];
array = Fibonachi(array);
// string result = string.Concat(array);
Console.Write($"Если N = {N} -> ");
PrintArray(array);


// int[] RowNumber(int size)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] + i;

//     }

//     return arr;
// }

int[] Fibonachi(int[] arr)
{
  
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];

    }

    return arr;
}



void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

}