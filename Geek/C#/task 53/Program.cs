//местами первую и последнюю строку

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

int[,] ChangeRows(int[,] doublearray)

{
  
    int[] digit = new int[doublearray.GetLength(1)];

    for (int i = 0; i < doublearray.GetLength(1); i++)
    {
        digit[i] = doublearray[0, i];
        doublearray[0, i] = doublearray[doublearray.GetLength(0)-1, i];
        doublearray[doublearray.GetLength(0)-1, i] = digit[i];
    }
    return doublearray;
}

void PrintMatrix(int[,] matrix)
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

int [,] array2d = CraitMatrix(3, 4, 0, 10);
PrintMatrix(array2d);

Console.WriteLine("");
ChangeRows(array2d);
PrintMatrix(array2d);

