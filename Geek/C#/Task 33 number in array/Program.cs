// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
//  4; массив [6, 7, 19, 345, 3] -> нет 
//  3; массив [6, 7, 19, 345, 3] -> да

int[] CreatArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

bool Number(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (n == array[i]) return true;


    }
    return false;
}

int[] arr = CreatArray(5, 1, 10);

Random rnd = new Random();
int N = rnd.Next(1, 10);
Console.Write($"{N}; массив ");

PrintArray(arr);


string result = Number(arr, N) ? " -> да" : " -> нет";
Console.WriteLine(result);



