// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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



int[,] SortringRows(int[,] matrix)
{
    int min = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int row = 0; row < matrix.GetLength(1) - 1; row++)
    {
        for (int j = row + 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, row] > matrix[i, j])
            {
                min = matrix[i, row];
                matrix[i, row] = matrix[i, j];
                matrix[i, j] = min;
            }
        }
    }
    }
    
    return matrix;
}



int[,] array2d = CraitMatrix(4, 4, -9, 9);
PrintMatrix(array2d);

Console.WriteLine("");

SortringRows(array2d);
PrintMatrix(array2d);


