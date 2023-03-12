// massive 8 lenthg random 0 and 1

// int [] array = new int[8];
// array[i] = new Random().Next(0,1);
// Console.WriteLine(array);

void Massive(int[] arr)
{
    Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0,2);
        }
    
}

void Printarray(int[]arr)
{
    int count = arr.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }

}

int [] array = new int[8];

Massive(array);
Printarray(array);