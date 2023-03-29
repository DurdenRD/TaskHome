// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] Multiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int r = 0; r < matrixA.GetLength(0); r++)
    {
        for (int i = 0; i < matrixB.GetLength(1); i++)
        {
            matrixC[r, i] = 0;
            for (int j = 0; j < matrixB.GetLength(0); j++)
            {
                matrixC[r, i] += matrixA[r, j] * matrixB[j, i];
            }
        }
    }
    

    return matrixC;
}

bool MultiplicationTrue(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(0) == matrixB.GetLength(1) & matrixA.GetLength(1) == matrixB.GetLength(0))
        return true;
    else
        return false;
}

int[,] matrix1 = CraitMatrix(3, 2, 0, 2);
int[,] matrix2 = CraitMatrix(2, 3, 0, 2);

// int[,] matrix1 = { { 0, 3}, { 3, 5}, {0, 1} };
// int[,] matrix2 = { { 1, 2, 1 }, { 4, 2, 1 } };


PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();

int[,] matrix3 = Multiplication(matrix1, matrix2);

if (MultiplicationTrue(matrix1, matrix2))
{
    PrintMatrix(matrix3);
}
else
    Console.WriteLine(
        "Количество столбцов одной матрицы не соответсвует количеству столбцов другой матрицы"
    );
