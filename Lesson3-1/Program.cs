// Упорядочение элементов массива по убыванию
int[] arr = { 1, 8, 6, 5, 4, 9, 0, 2, 7, 5, 3, 2 };
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

// Печать массива
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
}

//Упорядочивание массива
void SelectionSort(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < count; j++)
        {
            if (array[i] < array[minPosition])
                minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

