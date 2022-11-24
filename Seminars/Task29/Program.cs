// Напишите программу, которая:
// 1. задаёт массив из 8 элементов 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Задайте длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте минимальное число диапазона для генерации массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте максимальное число диапазона для генерации массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];

void PrintRandomArray(int[] arr, int minN, int maxN)
{
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(minN, maxN);
        Console.Write($"{arr[i]} ");
    }
}

PrintRandomArray(array, min, max);
