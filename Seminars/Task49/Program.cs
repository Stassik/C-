// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их
// квадраты.

int row = 4;
int col = 4;

int[,] CreateArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
    return arr;
}
void PrintArray(int[,] arr, int m, int n)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] NewArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0)) arr[i, j] *= arr[i, j];
        }
    }
    return arr;
}
int[,] array = CreateArray(row, col);
PrintArray(array, row, col);
int[,] newArray = NewArray(array);
Console.WriteLine();
PrintArray(newArray, row, col);