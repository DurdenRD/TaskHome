// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.


int[] array = CreatArray(5, -100, 100);

int result = SummNumber(array);

PrintArray(array);
Console.Write($" -> {result}");

int[] CreatArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[arr.Length - 1]}]");
    }


}

int SummNumber(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 == 1) count += arr[i];
    }
    return count;
}
