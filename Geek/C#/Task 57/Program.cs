//частотный словарь, сколько повторяется элемент.
// двумерного массива

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

int[] CraitArray(int[,] matrix)
{
    int size = matrix.GetLength(1) * matrix.GetLength(0);
    int[] array = new int[size];
    int n = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[n] = matrix[i, j];
            n++;

        }

    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[array.Length - 1]}]");
    }


}

// void PrintCountRepeat(int[] array)
// {


//     for (int i = 0; i < array.Length; i++)
//     {
//         int count = 0;

//         for (int j = 0; j < array.Length; j++)
//         {
//             if (array[i] == array[j])

//             {
//                 count++;
//             }
//         }

//         Console.WriteLine($"{array[i]} повторяется -> {count} раз");

//     }


// }


void PrintCountRepeat(int[] array)
{    

    int count = 1;
    for (int j = 1; j < array.Length; j++)
    {
        if (array[j - 1] != array[j])
        {

            Console.WriteLine($"{array[j - 1]} повторяется -> {count} раз");
            count = 1;
        }
        else count++;

        if (j == array.Length - 1) Console.WriteLine($"{array[j]} повторяется -> {count} раз");

    }

}

int[,] array2d = CraitMatrix(2, 3, 1, 10);

PrintMatrix(array2d);

Console.WriteLine("");

int[] arrayRepeat = CraitArray(array2d);
PrintArray(arrayRepeat);

Array.Sort(arrayRepeat);

Console.WriteLine("");
PrintArray(arrayRepeat);

Console.WriteLine("");
PrintCountRepeat(arrayRepeat);


