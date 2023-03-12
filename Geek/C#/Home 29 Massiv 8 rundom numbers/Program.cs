// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int [] array = new int[8];
Array(array);
Printarray(array);
Console.Write($"{array[array.Length-1]}");

void Array(int [] arr)
{
    Random random = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
     array[i] = random.Next(-99,100);   
    }
}

void Printarray(int [] arr)

{
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    

}
