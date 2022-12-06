// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент
// входных данных.

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
void PrintNewArray(int[] newArr)
{
    Console.Write("[");
    for (int i = 0; i < newArr.Length; i++)
    {
        if (i < newArr.Length - 1) Console.Write($"{newArr[i]}; ");
        else Console.Write($"{newArr[i]}");
    }
    Console.WriteLine("]");
}

int[] ToArray(int[,] matrix)
{
    int length = matrix.GetLength(0) * matrix.GetLength(1);
    int[] arr = new int[length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[k] = matrix[i, j];
            k++;
        }
    }
    return arr;
}

// void CountNumbArray(int[] arr)
// {
//     int numb = arr[0];
//     int count = 0;
//     for (int i = 0; i < arr.Length ; i++)
//     {
//         if (arr[i] == numb) 
//         {
//             count++;
//             numb = arr[i];
//         }
//         else
//         {
//             Console.WriteLine($"{arr[i-1]} встречается {count} раз.");
//             count = 0;
//             count++;
//             numb = arr[i];
//         }
        
//     }
//     Console.WriteLine($"{numb} встречается {count} раз.");
// }

int[,] CountMatrix(int[] arr)
{
    int count2 = 1;
    int[,] matrix = new int[count2, 2];
    int numb = arr[0];
    int count = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    for (int i = 0; i < arr.Length ; i++)
    {
        if (arr[i] == numb) 
        {
            count++;
            numb = arr[i];
        }
        else
        {
            matrix[i, j] = matrix[arr[i-1], count];
            count = 0;
            count++;
            count2++;
            numb = arr[i];
        }
        
    }
    }
   return matrix; 
}



Console.Write("Введите количество строк: ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colNum = Convert.ToInt32(Console.ReadLine());

if (rowNum < 0 || colNum < 0) Console.WriteLine("Вы ввели отрицательное число. Введите положительное целое число!.");
else
{
    int[,] matrixArray = CreateMatrix(rowNum, colNum);
    PrintArray(matrixArray);
    Console.WriteLine();

    int[] array = ToArray(matrixArray);
    PrintNewArray(array);
    Array.Sort(array);
    PrintNewArray(array);

    int[,] matrix = CountMatrix(array);
    PrintArray(matrix);
    // CountNumbArray(array);
}