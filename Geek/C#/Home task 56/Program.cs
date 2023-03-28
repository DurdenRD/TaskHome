// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
//с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine("]");
// }

int[] SortringRows(int[,] matrix)
{
    int[] summRows = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summRows[i] += matrix[i, j];
        }
    }

    return summRows;
}

int MinRows(int[] array)
{
    int min = array[0];
    int minrows = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            array[i - 1] = array[i];
            array[i] = min;
            minrows = i + 1;
        }
    }

    return minrows;
}

int[,] array2d = CraitMatrix(4, 4, -9, 9);
PrintMatrix(array2d);

int[] arrayrows = SortringRows(array2d);

// PrintArray(arrayrows);
// Console.WriteLine("");

int result = MinRows(arrayrows);

Console.WriteLine("");
Console.WriteLine($"Строка с наименьшей суммой элементов -> {result}");
