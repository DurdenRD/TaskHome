// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[]  array = Array(123, 1, 123);
int result = FindElement(array);
PrintArray(array);

Console.WriteLine($"{result} элемнтов, значение которых лежат в отрезке [10,99]");

int [] Array(int size, int min,int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

int FindElement(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    
    {
        if (arr[i] > 9 & arr[i] < 100) count+=1;
    }
    return count;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("");
}

