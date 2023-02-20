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

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        //int minPosition = i;
        int maxPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            //if(array[j] < array[minPosition])
            if(array[j] > array[maxPosition])
            //minPosition = j;
            maxPosition = j;

        }

        int temporary = array[i];
        //array[i] = array[minPosition];
        array[i] = array[maxPosition];
        //array[minPosition] = temporary;
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


