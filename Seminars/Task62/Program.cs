// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrix(int rowNum, int colNum)
{
    int[,] matrix = new int[rowNum, colNum];
    int colLength = matrix.GetLength(1);
    int rowLength = matrix.GetLength(0);
    int step = 0;
    int num = 1;
    int cycles = 0;
    if(rowLength % 2 == 0)
        cycles = rowLength/2;
    else
        cycles = rowLength/2+1;

    while (step <= cycles)
    {     
        for (int j = step; j < colLength - step - 1; j++)
        {
            int row = step;
            matrix[row, j] = num;
            num++;
        }
        for (int i = step; i < rowLength - step - 1; i++)
        {
            int col = colLength- step -1;
            matrix[i, col] = num;
            num++;
        }

        for (int k = colLength - step - 1; k > step; k--)
        {
            int rowRev = rowLength - step - 1;
            matrix[rowRev, k] = num;
            num++;
        }

        for (int m = rowLength - step - 1; m > step; m--)
        {
            int colRev = step;
            matrix[m, colRev] = num;
            num++;
        }
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