int[] arr = { 5, 3, 9, 1, 2, 4, 5, 3, 2, 8, 7, 1 };

void arrOutput(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            maxPosition = j;
        }


        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

arrOutput(arr);
selectionSort(arr);
arrOutput(arr);