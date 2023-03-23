// Задача 50: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив: 
//1 4 7 2
// 5 9 23
// 8 4 24
// [1,7] -> такого элемента в массиве нет

Console.WriteLine("Введите значение строки элемента: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение столбца элемента: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CraitMatrix(3, 4, -99, 100);
PrintMatrix(array2d);

ReturnDigit(x, y, array2d);

// {
// if (true) Console.Write($"элемент [{x},{y}] = {array2d[x, y]}");
//  else Console.WriteLine($"[{x},{y} -> такого элемента нет"); 
// }




string ReturnDigit(int row, int colums, int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (row == i & colums == j)
            {
                 Console.Write($"элемент [{x},{y}] = {array2d[x, y]}");
            }
        }
    }
}




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
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }


}

