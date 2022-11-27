// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumOddNumber(int[] array)
{
    int sumNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sumNum += array[i];
    }
    return sumNum;
}

Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона чисел: ");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона чисел: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(sizeArray, minNum, maxNum);
int sumOdd = SumOddNumber(arr);
PrintArray(arr);
Console.Write($"Сумма чисел массива стоящих на нечетных позициях составляет {sumOdd}");