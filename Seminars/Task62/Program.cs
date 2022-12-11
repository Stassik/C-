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
    int step = 1;
    int num = 1;
    int cycles = 0;
    if (colLength > rowLength)
    {
        if (colLength % 2 == 0)
            cycles = colLength / 2+1;
        else
            cycles = colLength / 2+2;
    }
    else
    {
        if (rowLength % 2 == 0)
            cycles = rowLength / 2+1;
        else
            cycles = rowLength / 2+2;
    }


    while (step <= cycles)
    {

        for (int j = step - 1; j < colLength - step; j++)
        {
            int row = step - 1;
            matrix[row, j] = num;
            num++;
        }
        for (int i = step - 1; i < rowLength - step; i++)
        {
            int col = colLength - step;
            matrix[i, col] = num;
            num++;
        }

        for (int k = colLength - step; k > step - 1; k--)
        {
            int rowRev = rowLength - step;
            matrix[rowRev, k] = num;
            num++;
        }

        for (int m = rowLength - step; m > step - 1; m--)
        {
            int colRev = step - 1;
            matrix[m, colRev] = num;
            num++;
        }
        step++;

        if (step == cycles)
        {
            step++;
            for (int j = step - 1; j <= colLength - step; j++)
            {
                int row = step - 1;
                matrix[row, j] = num;
                num++;
            }
            for (int i = step - 1; i < rowLength - step; i++)
            {
                int col = colLength - step;
                matrix[i, col] = num;
                num++;
            }

            for (int k = colLength - step; k > step - 1; k--)
            {
                int rowRev = rowLength - step;
                matrix[rowRev, k] = num;
                num++;
            }

            for (int m = rowLength - step; m > step - 1; m--)
            {
                int colRev = step - 1;
                matrix[m, colRev] = num;
                num++;
            }
            break;
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