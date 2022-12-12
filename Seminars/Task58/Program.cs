// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MergeMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)                      
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int merge = 0;
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                    merge = matrixA[i, k]*matrixB[k, j];
                    sum += merge;  
            }
            matrix[i, j] = sum; 
        }
    }
    return matrix;
}
Console.WriteLine("Важно! Столбцы матрицы A должны быть равны строкам матрицы B");
Console.WriteLine();
Console.Write("Введите количество строк матрицы A: ");
int rowA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы A: ");
int colA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы B: ");
int rowB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцовк матрицы B: ");
int colB = Convert.ToInt32(Console.ReadLine());

if (colA == rowB)
{
    int[,] matrixArrayA = CreateMatrix(rowA, colA);
    PrintMatrix(matrixArrayA);
    Console.WriteLine();
    int[,] matrixArrayB = CreateMatrix(rowB, colB); //столбцы матрицы А должны быть равны строкам матрицы В
    PrintMatrix(matrixArrayB);
    Console.WriteLine();
    int[,] matrixArray = MergeMatrix(matrixArrayA, matrixArrayB);
    PrintMatrix(matrixArray);
}
else 
{
    Console.WriteLine($"Перемножение матриц невозможно! Столбцы матрицы A должны быть равны строкам матрицы B");
}

