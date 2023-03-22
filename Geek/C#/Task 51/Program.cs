// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив: 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int Sum(int[,] matrix)
{
    int sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }
    }
    return sum;
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

// void PrintSum(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
            
//             if(i == j ) Console.Write($" {matrix[i, j]} + ");
//         }
       
//     }
//      Console.Write(" = ");

// }

void PrintSum(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
         if(i!=matrix.GetLength(0)-1) Console.Write($" {matrix[i, i]} + ");
        else Console.Write($" {matrix[i, i]} = ");
    }

}



int[,] array2d = CraitMatrix(3, 4, 1, 9);
PrintMatrix(array2d);

Console.WriteLine("");

PrintSum(array2d);

int result = Sum(array2d);
Console.Write(result);


