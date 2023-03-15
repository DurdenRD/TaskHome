// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



double[] array = CreatArray(5, -100, 100);

double result = DifferentMaxMin(Max(array), Min(array));
// Math.Round(result, 1);
PrintArray(array);
Console.Write($" -> {result}");

// **double num = rnd.NextDouble() * (max - min) + min;**
// **array[i] = Math.Round(num, 1)** - один знак после запятой

double[] CreatArray(int size, int min, int max)

{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[arr.Length - 1]}]");
    }


}

double Max(double[] arr)
{
    double maximus = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] >= maximus) maximus = arr[i];
    }
    return maximus;
}

double Min(double[] arr)
{
    double minimus = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minimus) minimus = arr[i];
    }
    return minimus;
}

double DifferentMaxMin(double maximus, double minimus)

{

    double different = maximus - minimus;
    if (different < 0) different = -different;

    return Math.Round(different, 1);
}



// int DifferentMaxMin(int maximus, int minimus)
// {
//     int Diffrent = maximus - minimus;
// }
