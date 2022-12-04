// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int row = 5;
int col = 5;

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
            Console.Write($"{arr[i, j], 4}");
        }
        Console.WriteLine();
    }
}

int Sum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ((i == j)) sum += arr[i, j];
        }
    }
    return sum;
}
int[,] array = CreateArray(row, col);
PrintArray(array, row, col);
int sumNum = Sum(array);
Console.WriteLine(sumNum);