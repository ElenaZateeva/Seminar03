// Упорядочение элементов массива по убыванию
int[] arr = { 1, 8, 6, 5, 4, 9, 0, 2};
PrintArray(arr);
Console.WriteLine();
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
    for (int i = 0; i < count-1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < count; j++)
        {
            if (array[j] > array[maxPosition])
                maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

