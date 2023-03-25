//строки на столбцы если возможно


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

int[,] ChangeRowsColums(int[,] matrix)

{

    int[,] matrix2 = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix2[j, i] = matrix[i, j];
        }
    }
    return matrix2;
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


// bool ChangeTrue(int[,] matrix)
// {
//     return matrix.GetLength(0) == matrix.GetLength(1);
// }

int[,] array2d = CraitMatrix(4, 3, 0, 10);
PrintMatrix(array2d);

Console.WriteLine("");

// if (ChangeTrue(array2d))
// {
    int[,] arrayd2 = ChangeRowsColums(array2d);
    PrintMatrix(arrayd2);
// }
// else Console.WriteLine("Невозможно");






; //? PrintMatrix(arrayd2) : Console.WriteLine("Невозможно"); 

//PrintMatrix(arrayd2);