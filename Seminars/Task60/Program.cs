// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrix(int row, int col, int depth)
{
    Random rnd = new Random();
    int[,,] matrix = new int[row, col, depth];
    int[] arr = new int[row * col * depth];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int rndNum = rnd.Next(10, 100);
                bool exist = true;
                while (exist == true)
                {
                    rndNum = rnd.Next(10, 100);
                    exist = false;
                    for (int m = 0; m < matrix.GetLength(0); m++)
                    {
                        for (int n = 0; n < matrix.GetLength(1); n++)
                        {
                            for (int r = 0; r < matrix.GetLength(2); r++)
                            {
                                if (matrix[m, n, r] == rndNum) exist = true;
                            }
                        }
                    }
                }

                if (exist == false) matrix[i, j, k] = rndNum;
            }
        }

    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],4} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину: ");
int depthNum = Convert.ToInt32(Console.ReadLine());

if (rowNum < 0 || colNum < 0 || depthNum < 0) Console.WriteLine("Вы ввели отрицательное число. Введите положительное целое число!.");
else
{
    int[,,] matrixArray = CreateMatrix(rowNum, colNum, depthNum);
    PrintMatrix(matrixArray);
    Console.WriteLine();

}
