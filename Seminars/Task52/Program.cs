// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintNewArray(double[] newArr)
{
    Console.Write("[");
    for (int i = 0; i < newArr.Length; i++)
    {
        if (i < newArr.Length - 1) Console.Write($"{newArr[i]}; ");
        else Console.Write($"{newArr[i]}");
    }
    Console.WriteLine("]");
}

double[] ArithmeticMean(int[,] arr)
{
    double[] newArr = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double jArr = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            jArr += arr[i, j];
        }
        newArr[j] = Math.Round(jArr / arr.GetLength(0), 1, MidpointRounding.ToZero);
    }
    return newArr;
}


Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int col = Convert.ToInt32(Console.ReadLine());

if (row > 0 && col > 0)
{
    int[,] array = CreateArray(row, col);
    PrintArray(array);
    Console.WriteLine();
    double[] newArray = ArithmeticMean(array);
    PrintNewArray(newArray);
}
else if (row == 0 || col == 0)
{
    Console.WriteLine("Одно из значений райно нулю. Введите целое число больше нуля!.");
}
else
{
    Console.WriteLine("Вы ввели отрицательное число. Введите целое число больше нуля!.");
}
