// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: A[m, n] = m+n.
//  Выведите полученный массив на экран.
// m = 3, n = 4. 012 3 123 4 234 5

// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5-233 -2 
// 77 3 8 1



int[,] CraitMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums]; // 0, 1

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;

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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }


}

int[,] array2d = CraitMatrix(3, 4);
PrintMatrix(array2d);