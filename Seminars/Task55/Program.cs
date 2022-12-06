// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 

// В случае, если это невозможно, программа должна вывести сообщение для
// пользователя.

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

void ReposMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = 0;
        for (int i = j; i < matrix.GetLength(0); i++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
        
    }
}

// int[,] ReposMatrix(int[,] matrix)
// {
//     int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
       
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
            
//             matrix2[i, j] = matrix[j, i];
            
//         }
        
//     }
//     return matrix2;
// }

Console.Write("Введите количество строк: ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colNum = Convert.ToInt32(Console.ReadLine());

if (rowNum < 0 || colNum < 0) Console.WriteLine("Вы ввели отрицательное число. Введите положительное целое число!.");
else if (rowNum != colNum) Console.WriteLine("Ошибка. Количество строк не равно количеству столбцов.");
else
{
    int[,] matrixArray = CreateMatrix(rowNum, colNum);
    PrintArray(matrixArray);
    Console.WriteLine();
    ReposMatrix(matrixArray);
    PrintArray(matrixArray);
}