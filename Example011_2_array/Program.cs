// Сортировка массива

Console.Clear();

int[] arr = {1, 5, 6, 7, 8, 9, 3, 5,};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    
}

PrintArray(arr);
