// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = Array(5, 1, 10);

int size1 = array.Length / 2 + array.Length % 2;
Console.WriteLine($"size = {size1}");
PrintArray(array);

Console.Write(" -> новый массив -> ");

int[] array2 = Multiplicate(array);

PrintArray(array2);




int[] Array(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

int[] Multiplicate(int[] arr)
{
    int size = arr.Length / 2 + arr.Length % 2;
    int[] mult = new int[size];
    for (int i = 0; i <= size-i; i++)

    {
        if (i != size-1) mult[i] = arr[i] *= arr[arr.Length - 1 - i];
        else mult [i] = arr[i];
    }
    return mult;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

}

