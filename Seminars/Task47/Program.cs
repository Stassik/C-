// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,57 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



double[,] CreateArray (int m, int n)
{
    double[,] arr = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(rnd.NextDouble(), 1, MidpointRounding.ToZero);
        }
    }
    return arr;
}
void PrintArray (double[,] arr, int m, int n)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 4} ");
        }
        Console.WriteLine();
    }        
}

Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int col = Convert.ToInt32(Console.ReadLine());
if (row > 0 && col >0)
{
    double[,] array = CreateArray(row, col);
    PrintArray(array, row, col);
}
else if (row == 0 || col == 0)
{
    Console.WriteLine("Одно из значений райно нулю. Введите целое число больше нуля!.");
}
else 
{
    Console.WriteLine("Вы ввели отрицательное число. Введите целое число больше нуля!.");  
}
