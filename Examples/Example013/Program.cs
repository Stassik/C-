// string[,] table = new string[2, 5];
// table[1, 2] = "слово";

// for (int row = 0; row < 2; row++)
// {
//     for (int column = 0; column < 5; column++)
//     {
//         Console.Write($"-{table[row, column]}");
//     }
//     Console.WriteLine();
// }



void PrintArray(int[,] matr)
{
    for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int column = 0; column < matr.GetLength(1); column++)
        {
            Console.Write($"{matr[row, column]} ");
        }
        Console.WriteLine();
    }
}

void FillArray( int[,] matr)
{
    Random rnd = new Random();
   for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int column = 0; column < matr.GetLength(1); column++)
        {
            matr[row, column] = rnd.Next(1, 100);
        }
    } 
}

int[,] matrix = new int[4, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);

