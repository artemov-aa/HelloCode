Console.Clear();

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 99);
    }
}

void PrintArray(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Сортировка выбором по возрастанию.
void SelectionSortUp(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        // Запоминаем позицию рабочего элемента.
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporaryPosition = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporaryPosition;
    }
}

// Сортировка выбором по убыванию.
void SelectionSortDown(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        // Запоминаем позицию рабочего элемента.
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporaryPosition = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporaryPosition;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
SelectionSortUp(array);
PrintArray(array);
SelectionSortDown(array);
PrintArray(array);