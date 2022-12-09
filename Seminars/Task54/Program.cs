// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrix(int row, int col)
{
    Random rnd = new Random();
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int[,] SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < (matrix.GetLength(1) - k); k++)
        {
            int temp = 0;
            for (int j = k; j < matrix.GetLength(1) - k; j++)
            {
                int min = matrix[i, matrix.GetLength(1) - k - 1];
                int max = matrix[i, k];
                if (matrix[i, j] > max)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
                else if (matrix[i, j] < min)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, matrix.GetLength(1) - k - 1];
                    matrix[i, matrix.GetLength(1) - k - 1] = temp;
                }
            }
        }
    }
    return matrix;
}

Console.Write("Введите количество строк: ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colNum = Convert.ToInt32(Console.ReadLine());

if (rowNum < 0 || colNum < 0) Console.WriteLine("Вы ввели отрицательное число. Введите положительное целое число!.");
else
{
    int[,] matrixArray = CreateMatrix(rowNum, colNum);
    PrintMatrix(matrixArray);
    Console.WriteLine();

    int[,] sortMatrixArray = SortMatrix(matrixArray);
    PrintMatrix(sortMatrixArray);
}
