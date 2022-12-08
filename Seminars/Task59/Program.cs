// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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

void PrintArray(int[,] matrix)
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

int FindMinRowElement(int[,] matrix)
{
    int min = matrix[0, 0];
    int minRow = 0;
    int minCol = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    return minRow;
    // Console.WriteLine($"Минимальное число в матрице {min}. Его позиция ({minRow}, {minCol}).");
}

int FindMinColElement(int[,] matrix)
{
    int min = matrix[0, 0];
    int minRow = 0;
    int minCol = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    return minCol;
    // Console.WriteLine($"Минимальное число в матрице {min}. Его позиция ({minRow}, {minCol}).");
}

int[,] CorrectMatrix(int[,] matrix, int minRow, int minCol)
{
    int[,] matrixCorrect = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrixCorrect.GetLength(0); i++)
    {
        if (i != minRow)
        {
            for (int j = 0; j < matrixCorrect.GetLength(1); j++)
            {
                if (j != minCol)
                {
                    matrixCorrect[i, j] = matrix[i, j];
                }
            }
        }
    }
    return matrixCorrect;
}

Console.Write("Введите количество строк: ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colNum = Convert.ToInt32(Console.ReadLine());

if (rowNum < 0 || colNum < 0) Console.WriteLine("Вы ввели отрицательное число. Введите положительное целое число!.");
else
{
    int[,] matrixArray = CreateMatrix(rowNum, colNum);
    PrintArray(matrixArray);
    Console.WriteLine();
    int row = FindMinRowElement(matrixArray);
    int col = FindMinColElement(matrixArray);
    int[,] correct = CorrectMatrix(matrixArray, row, col);
    PrintArray(correct);

}
