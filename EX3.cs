int[,] array = new int[3, 3];
int[,] array_cp = new int[3, 3];

array = FillArray(array, 1, 10);
PrintArray(array);
CopyArray(array_cp, array);
 Console.WriteLine();
PrintArray(array_cp);

int[,] FillArray(int[,] array, int minimum, int maximum)
{

    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(minimum, maximum);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CopyArray(int[,] arrayOrig, int[,] arrayCopy)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array_cp[i, j] = array[i, j];
        }
    }
}