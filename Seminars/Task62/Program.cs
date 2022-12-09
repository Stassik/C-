// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    int num = 1;
    int rowLength = matrix.GetLength(0);
    int colLength = matrix.GetLength(1);
    int i = 0;
    int j = 0;

    for (int temp = 0; temp < rowLength/2; temp++)
    {
        Console.WriteLine(temp);

        for (i = 0 + temp; i < rowLength; i++)
        {
            
            for (j = temp; j < matrix.GetLength(1); j++)
            {

                matrix[i, j] = num;
                num++;

                if ((j == colLength - 1 - temp))
                {
                    for (i++; i < rowLength; i++)
                    {
                        matrix[i, j] = num;
                        num++;
                    }
                    colLength--;
                }
            }
        }
        for (i = rowLength - 1 - temp; i > rowLength - i; i--)
        {
            for (j = colLength - 1 - temp; j >= 0; j--)
            {
                matrix[i, j] = num;
                num++;
                rowLength--;
                if ((j == 0))
                {
                    for (i--; i > rowLength - i; i--)
                    {
                        matrix[i, j] = num;
                        num++;
                    }

                }
            }
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