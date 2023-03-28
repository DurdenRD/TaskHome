//удалить строку и столбец минимального элемента массива
//

int[,] CraitMatrix(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums]; // 0, 1
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}
(int Rows, int Colums) MinVolue(int[,] matrix)
{
    int colums = 0, rows = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rows, colums])
            {
                rows = i;
                colums = j;
            }
        }
    }
    return (rows, colums);
}

int[,] CraitMatrix2(int[,] matrix, (int, int) indexer)
{
    int[,] matrix2 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        if (m == indexer.Item1) m++;
       
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (n == indexer.Item2)
                n++;
            matrix2[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return matrix2;
}

int[,] array2d = CraitMatrix(4, 4, -9, 9);

PrintMatrix(array2d);

Console.WriteLine("");

var index = MinVolue(array2d);
Console.WriteLine($"минимальный элемент в строке - {index.Item1+1} и столбце - {index.Item2+1}");

Console.WriteLine("");

int[,] matrix0 = CraitMatrix2(array2d, index);
PrintMatrix(matrix0);


// Array.Sort(arrayRepeat);

// Console.WriteLine("");
// PrintCountRepeat(arrayRepeat);
