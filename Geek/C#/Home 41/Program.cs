// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] array = new int[5];

Console.WriteLine("ведите число a: ");
array[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите число b: ");
array[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите число c: ");
array[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите число d: ");
array[3] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите число e: ");
array[4] = Convert.ToInt32(Console.ReadLine());

int result = Positiv(array);
Printarray(array);
Console.Write($" -> {result}");

int Positiv(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count+=1;
    }
    return count;
}

void Printarray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

}