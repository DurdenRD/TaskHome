void CreatSpiral(int[,] matrix)
{
    int i = 0;
    int j = -1;
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    int max = x * y;
    int row = 0;
    int colum = 1;

    for (int n = 1; n <= max; n++)
    {
       if (j + colum >= 0 && j + colum < y && i + row >= 0 & i + row < x && matrix[i + row, j + colum] == 0)
        
        {
            i += row;
            j += colum;
            matrix[i, j] = n;
        }
        
        else
        {
            if (colum == 1)
            {
                colum = 0;
                row = 1;
            }
            else
            {
                if (row == 1)
                {
                    colum = -1;
                    row = 0;
                }
                else
                {
                    if (colum == -1)
                    {
                        colum = 0;
                        row = -1;
                    }
                    else
                    {
                        if (row == -1)
                        {
                            colum = 1;
                            row = 0;
                        }
                    }
                }
            }
            i += row;
            j += colum;
            matrix[i, j] = n;
        }
        
           
            
        
    }
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

int[,] array2d = new int[4, 4];
PrintMatrix(array2d);

Console.WriteLine();

CreatSpiral(array2d);
PrintMatrix(array2d);
