// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArray(int size)
{
    Random rnd = new Random();
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble(), 2, MidpointRounding.ToZero);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindSub(double min, double max)
{
    double sub = max - min;
    return Math.Round(sub, 2, MidpointRounding.ToZero);
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArray(sizeArray);
double minArrNum = FindMin(arr);
double maxArrNum = FindMax(arr);
PrintArray(arr);
double subArrNum = FindSub(minArrNum, maxArrNum);
Console.WriteLine($"Максимальное число массива {maxArrNum}. Минимальное число массива {minArrNum}. Разница этих чисел {subArrNum}.");