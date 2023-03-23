// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

double[,] CraitMatrix(int rows, int colums, int min, int max)
{
    double[,] matrix = new double[rows, colums]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);

        }
    }
    return matrix;
}

double[] CraitAvaregeArray(double[,] matrix)
{
    double[] arrayAverage = new double[matrix.GetLength(1)];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arrayAverage[j] += matrix[i, j] / matrix.GetLength(1);
            arrayAverage[j] = Math.Round(arrayAverage[j], 1);
        }

    }

    return arrayAverage;
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }


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

double[,] array2d = CraitMatrix(3, 4, 1, 9);
PrintMatrix(array2d);
double[] arrayAverageColums = CraitAvaregeArray(array2d);
Console.WriteLine("Cреднее арефметическое элементов в столбце:");
PrintArray(arrayAverageColums);