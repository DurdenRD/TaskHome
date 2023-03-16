Console.WriteLine("оригинальный массив ->");
int[] array = CreatArray(5, 0, 10);
Printarray(array);

Console.WriteLine("");

int[] array2 = CopyArray(array);
Console.WriteLine("репродукция массиав ->");
Printarray(array2);




int[] CreatArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;

}

void Printarray(int[] arr)
{
    int count = arr.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }

}

int[] CopyArray(int[] arr)
{
    int[] arr2 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr2[i] = arr[i];
    }
    return arr2;
}