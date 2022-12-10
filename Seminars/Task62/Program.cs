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
    int temp = 0;

    while (temp <= matrix.GetLength(0)/2)
    {
        for (i = temp; i < rowLength; i++)
        {
            for (j = temp; j < matrix.GetLength(1) - temp; j++)
            {
                matrix[i, j] = num;
                num++;
                if ((j == colLength -1))
                {
                    for (i++; i < rowLength ; i++)
                    {
                        matrix[i, j] = num;
                        num++;
                    }
                    colLength--;;
                }
            }
        }
        for (i = rowLength - temp-1; i > rowLength - i; i--)
        {
            for (j = colLength - 1 - temp; j >= 0; j--)
            {
                Console.WriteLine($"J- {j}");
                matrix[i, j] = num;
                num++;
                rowLength--;
                
                if ((j == temp))
                {
                    for (i--; i >= rowLength - i; i--)
                    {
                        Console.WriteLine($"I- {i}");
                        matrix[i, j] = num;
                        num++;
                    }
                }
                
            }
        }
        temp++;
        rowLength = matrix.GetLength(0) - temp;
        colLength = matrix.GetLength(1) - temp;
        Console.WriteLine($"TEMP- {temp}");
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