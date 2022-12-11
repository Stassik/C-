// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    int step = 0;
    int cols = matrix.GetLength(1);
    int rows = matrix.GetLength(0);
    int pos = 1;
    int cycles = 0;
    if(rows % 2 == 0)
        cycles = rows/2;
    else
        cycles = rows/2+1;

    while (step < cycles)
    {
        for (int i = step; i < cols - step; i++)
            matrix[step, i] = pos++;          

        for (int j = step+1; j < rows - step; j++)
        {
            int a = rows - 1 - step;
            matrix[j, a] = pos++;
            
        }

        for (int k = cols-step-2; k >= step; k--)
        {
            int c = rows - 1 - step;
            matrix[c, k] = pos++;
        }

        for (int z = rows-step-2; z > step ; z--)
            matrix[z,step] = pos++;

        step++;
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


}