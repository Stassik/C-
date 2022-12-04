// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[,] CreateArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine();
    }
}

bool CheckIndexPosition(int[,] arr, int mIndex, int nIndex)
{
    if ((mIndex < arr.GetLength(0)) && (nIndex < arr.GetLength(1))) return true;
    return false;
}

Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию искомого элемента массива.");
Console.WriteLine("Индекс строки: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Индекс столбца: ");
int colIndex = Convert.ToInt32(Console.ReadLine());

if (row > 0 && col > 0 && rowIndex > 0 && colIndex > 0)
{
    int[,] array = CreateArray(row, col);
    PrintArray(array);
    bool result = CheckIndexPosition(array, rowIndex, colIndex);
    Console.WriteLine(result ? array[rowIndex, colIndex] : "Такого элемента не существует.");
}
else if (row == 0 || col == 0 || rowIndex == 0 || colIndex == 0)
{
    Console.WriteLine("Одно из значений райно нулю. Введите целое число больше нуля!.");
}
else
{
    Console.WriteLine("Вы ввели отрицательное число. Введите целое число больше нуля!.");
}
