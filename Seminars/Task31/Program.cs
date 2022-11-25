// 1. Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. 
// 2. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumNegativeArray(int[] arr)
{
    int negative = 0;
    for (int i = 0; i < arr.Length; i++)
    {  
        if(arr[i] < 0) negative += arr[i];
    }
    return negative;
}

int SumPositiveArray(int[] arr)
{
    int positive = 0;
    for (int i = 0; i < arr.Length; i++)
    {  
        if(arr[i] > 0) positive += arr[i];
    }
    return positive;
}   

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int sumNegative = SumNegativeArray(array);
int sumPositive = SumPositiveArray(array);
Console.WriteLine($"Сумма отрицательный чисел - {sumNegative}. Сумма положительных чисел - {sumPositive}");

